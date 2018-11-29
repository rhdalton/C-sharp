using CarInsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceQuote.Models
{
    public class GetCarMakes
    {
        public static List<CarMakeVm> GetCarMakeList()
        {
            var carmakes = new List<CarMakeVm>();
            using (InsuranceQuotesEntities db = new InsuranceQuotesEntities())
            {
                foreach (var cm in db.carmakes)
                {
                    CarMakeVm make = new CarMakeVm();
                    make.id = cm.Id;
                    make.car_make = cm.car_make;
                    carmakes.Add(make);
                }
            }
            return carmakes;
        }
    }
}