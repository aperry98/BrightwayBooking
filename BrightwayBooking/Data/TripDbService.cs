using BrightwayBooking.Data;
using BrightwayBooking.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrightwayBooking
{
    public class TripDbService : ITripDbService
    {
        private readonly TripDbContext _context;

        public TripDbService(TripDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
            return invoice;
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
 
        }

        public async Task<Country> GetCountryByCurrCode(string currCode)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(x => x.CurrencyCode == currCode);
            return country;
        }

        public async Task<Invoice> GetInvoiceByIdAsync(int id)
        {
            return await _context.Invoices.Include(x => x.Country).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}