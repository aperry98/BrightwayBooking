using BrightwayBooking.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BrightwayBooking.Models
{
    public class IndexViewModel
    {
        public string CurrCode { get; set; }
        public int Days { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<SelectListItem> Countries {get;set;}
        public decimal AmountPerDay { get; set; }
    }
}