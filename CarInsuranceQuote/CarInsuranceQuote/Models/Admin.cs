using CarInsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.Models
{
    public class Admin
    {
        public List<AdminQuoteListVm> GetQuoteList(int limit = 20)
        {
            using (InsuranceQuotesEntities db = new InsuranceQuotesEntities())
            {
                var quotes = db.quotes.Take(limit);
                var quotelistVm = new List<AdminQuoteListVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new AdminQuoteListVm();
                    quoteVm.id = quote.Id;
                    quoteVm.fname = quote.fname;
                    quoteVm.lname = quote.lname;
                    quoteVm.email = quote.email;
                    quoteVm.premium = (int)quote.premium;
                    quotelistVm.Add(quoteVm);
                }
                return quotelistVm;
            }            
        }
    }
}