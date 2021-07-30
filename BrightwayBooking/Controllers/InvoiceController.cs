using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BrightwayBooking.Controllers
{
    public class InvoiceController : Controller
    {
        private ILogger<InvoiceController> _logger;
        private ITripDbService _tripDbService;
        private IHttpClientFactory _clientFactory;

        public InvoiceController(ILogger<InvoiceController> logger, ITripDbService tripDbService, IHttpClientFactory clientFactory)
        {
            _logger = logger;
            _tripDbService = tripDbService;
            _clientFactory = clientFactory;
        }
        // GET: InvoiceController
        public ActionResult Index()
        {
            return View();
        }

        // GET: InvoiceController/Details/5
        [HttpGet, Route("Invoice/Details/{id:int}")]
        public async Task<ActionResult> Details(int id)
        {
            var invoice = await _tripDbService.GetInvoiceByIdAsync(id);
            return View("Details",invoice);
        }

        // GET: InvoiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvoiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InvoiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InvoiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InvoiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
