using CarInsuranceQuote.Models;
using CarInsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class InsuranceController : Controller
    {
        // GET: Insurance
        public ActionResult Index()
        {
            /* might have Insurance home, but for this exercise, 
             * forward directlyto the quote page
             */
            return RedirectToAction("GetQuote");
        }

        [HttpPost]
        public ActionResult GetQuote(Quote userquote)
        {
            // check if all fields are filled in
            var validForm = Quote.CheckUserInputs(userquote);
            if (!validForm)
            {
                var model = new QuoteAndCarMakeVm();
                model.Carmakes = GetCarMakes.GetCarMakeList();
                model.UserQuote = userquote;
                ViewBag.ShowError = "d-block";
                return View(model);
            }
            else
            {
                // if valid fields, do quote calculations
                // and return quote value
                Insurance quote = new Insurance();
                var quoteresult = quote.SubmitQuote(userquote);
                var model = new QuoteResultVm();
                model.SetQuoteResultMv(quoteresult);
                return View("QuoteResult", model);
            }
        }

        public ActionResult GetQuote()
        {
            var model = new QuoteAndCarMakeVm();
            model.Carmakes = GetCarMakes.GetCarMakeList();
            model.UserQuote = new Quote().SetDefaultValues();
            ViewBag.ShowError = "d-none";
            return View(model);
        }

        public ActionResult Admin()
        {
            var model = new Admin().GetQuoteList();
            return View(model);
        }
    }
}