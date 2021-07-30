using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrightwayBooking.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public Guid InvoiceNumber { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int Days { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal AmountPerDay { get; set; }
        public decimal TotalTripAmount { get; set; }

    }
}
