using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.Models
{
    public class Insurance
    {
        /**
         * Default values for Premiums - can be adjusted here;
         *   (If this was a real insurance app, I'd put these values in a database table
         *   to allow admins to add and adjust values in a web based control panel)
        **/
        private int _base = 50;         // base monthly fee
        private int _under18 = 100;     // amount to add if age under 18
        private int _under25 = 25;      // amount to add if age under 25
        private int _over100 = 25;      // amount to add if age over 100 
        private int _carbefore2000 = 25;    // amount to add if car year before 2000
        private int _carafter2015 = 25;     // amount to add if car year after 2015
        private int _porche = 25;       // amount to add if car make is Porche
        private int _modelCarrera = 25; // amount to add if car model is 911 Carrera
        private int _perticket = 10;    // amount to add per speeding ticket
        private int _hasdui = 25;       // amount in % to add if has DUI
        private int _fullcoverage = 50; // amount in % to add if Full Coverage

        public Quote SubmitQuote(Quote quote)
        {
            /* cacluate user premium */
            int premium = _base;

            var dob = new DateTime(quote.doby, quote.dobm, quote.dobd);
            var age = CalculateAge(dob);

            if (age < 18) premium += _under18;
            else if (age < 25) premium += _under25;
            else if (age > 100) premium += _over100;

            if (quote.caryear < 2000) premium += _carbefore2000;
            else if (quote.caryear > 2015) premium += _carafter2015;

            /** Porche make Id is 18 */
            if (quote.carmake == 18)
            {
                premium += _porche;
                /**
                 * if this was real app, I'd put all car models in a database table
                 * but for this exercise, just using input field which could cause user input inconsistencies
                 **/
                if(quote.carmodel == "911 Carrera")
                {
                    premium += _modelCarrera;
                }
            }

            premium += quote.tickets * _perticket;
            
            if(quote.dui == 1)
            {
                premium = (int) (premium * (1 + _hasdui * .01));
            }
            if(quote.coverage == "full")
            {
                premium = (int) (premium * (1 + _fullcoverage * .01));
            }

            quote.premium = premium;
            AddQuoteToDb(quote);

            return quote;
        }

        private static void AddQuoteToDb(Quote quote)
        {
            using(InsuranceQuotesEntities db = new InsuranceQuotesEntities())
            {
                var addquote = new quote();
                addquote.fname = quote.fname;
                addquote.lname = quote.lname;
                addquote.email = quote.email;
                addquote.dob = new DateTime(quote.doby, quote.dobm, quote.dobd);
                addquote.car_year = (short) quote.caryear;
                addquote.car_make = quote.carmake;
                addquote.car_model = quote.carmodel;
                addquote.had_dui = (quote.dui == 1) ? true : false;
                addquote.sp_ticket = (short) quote.tickets;
                addquote.coverage = quote.coverage;
                addquote.premium = quote.premium;

                db.quotes.Add(addquote);
                db.SaveChanges();
            }
        }

        private static int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if(DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age -= 1;
            }
            return age;
        }
    }
}