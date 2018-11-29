using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.Models
{
    public class Quote
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public int dobm { get; set; }
        public int dobd { get; set; }
        public int doby { get; set; }
        public int caryear { get; set; }
        public int carmake { get; set; }
        public string carmodel { get; set; }
        public byte dui { get; set; }
        public int tickets { get; set; }
        public string coverage { get; set; }
        public int premium { get; set; }

        public Quote SetDefaultValues()
        {
            Quote dv = new Quote();
            dv.id = 0;
            dv.fname = "";
            dv.lname = "";
            dv.email = "";
            dv.dobm = 0;
            dv.dobd = 0;
            dv.doby = 0;
            dv.caryear = 0;
            dv.carmake = 0;
            dv.carmodel = "";
            dv.dui = 0;
            dv.tickets = 0;
            dv.coverage = "";
            dv.premium = 0;
            return dv;
        }

        public static bool CheckUserInputs(Quote userquote)
        {
            var dv = new Quote().SetDefaultValues();
            if(userquote.fname == dv.fname ||
                userquote.lname == dv.lname ||
                userquote.email == dv.email ||
                userquote.dobm == dv.dobm ||
                userquote.dobd == dv.dobd ||
                userquote.doby == dv.doby ||
                userquote.caryear == dv.caryear ||
                userquote.carmake == dv.carmake ||
                userquote.carmodel == dv.carmodel ||
                userquote.dui == dv.dui ||
                userquote.coverage == dv.coverage)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}