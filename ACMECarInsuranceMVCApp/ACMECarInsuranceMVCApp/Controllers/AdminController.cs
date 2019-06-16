using ACMECarInsuranceMVCApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ACMECarInsuranceMVCApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (ACMECarInsuranceEntities db = new ACMECarInsuranceEntities())
            {
                var quotes = db.ACMEQuotes.ToList();
                var quotesVms = new List<QuoteVm>();

                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.QuoteTotal = Convert.ToDecimal(quote.QuoteTotal);
                    quotesVms.Add(quoteVm);
                }
                return View(quotesVms);
            }
            
        }
    }
}