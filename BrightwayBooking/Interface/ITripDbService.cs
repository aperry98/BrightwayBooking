using BrightwayBooking.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrightwayBooking
{
    public interface ITripDbService
    {
        Task<Invoice> GetInvoiceByIdAsync(int id);
        Invoice CreateInvoice(Invoice invoice);
        Task<List<Country>> GetCountriesAsync();
        Task<Country> GetCountryByCurrCode(string currCode);
    }
}