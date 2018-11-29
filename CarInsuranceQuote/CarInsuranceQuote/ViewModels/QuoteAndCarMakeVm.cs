using CarInsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.ViewModels
{
    public class QuoteAndCarMakeVm
    {
        public List<CarMakeVm> Carmakes { get; set; }
        public Quote UserQuote { get; set; }
    }
}