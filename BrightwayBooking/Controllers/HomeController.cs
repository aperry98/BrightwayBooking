using BrightwayBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BrightwayBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITripDbService _tripDbService;
        private readonly IHttpClientFactory _clientFactory;

        public HomeController(ILogger<HomeController> logger, ITripDbService tripDbService, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _tripDbService = tripDbService;
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel();
            viewModel.CurrCode = "SGD";
            var countries = await _tripDbService.GetCountriesAsync();

            viewModel.Countries = countries.Select(x => new SelectListItem
            {
                Value = x.CurrencyCode,
                Text = x.Name
            }).ToList();
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IndexViewModel viewModel)
        {
            var invoice = new Invoice
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                InvoiceNumber = Guid.NewGuid(),
                Days = viewModel.Days,
                AmountPerDay = viewModel.AmountPerDay
            };
            var country = await _tripDbService.GetCountryByCurrCode(viewModel.CurrCode);
            invoice.CountryId = country.Id;
            invoice.TotalTripAmount = await CalculateTripTotalAsync(viewModel.CurrCode, viewModel.Days, viewModel.AmountPerDay);
            _tripDbService.CreateInvoice(invoice);

            return RedirectToAction("Details", "Invoice", new { id = invoice.Id });
        }

        private async Task<decimal> CalculateTripTotalAsync(string currCode, int days, decimal amountPerDay)
        {
            var client = _clientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://currency-exchange.p.rapidapi.com/exchange?to={currCode}&from=USD&q=1.0"),
                Headers =
                {
                    { "x-rapidapi-key", "10504f82admsh255f34713cdf5c8p1a1f03jsn7b1d54eb399b" },
                    { "x-rapidapi-host", "currency-exchange.p.rapidapi.com" },
                },
            };
            decimal tripTotal = 0;
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                Console.WriteLine(body);
                decimal exchangeRate = Convert.ToDecimal(body);
                tripTotal = Math.Round((amountPerDay * days) * exchangeRate, 2);
            }
            return tripTotal;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
