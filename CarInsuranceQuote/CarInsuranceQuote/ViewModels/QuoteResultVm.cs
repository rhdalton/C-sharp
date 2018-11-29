using CarInsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.ViewModels
{
    public class QuoteResultVm
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public int premium { get; set; }

        public void SetQuoteResultMv(Quote userquote)
        {
            fname = userquote.fname;
            lname = userquote.lname;
            premium = userquote.premium;
        }
    }    
}