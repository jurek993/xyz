using ClosedXML.Excel;
using CrossFinance.Enums;
using CrossFinance.Models;
using OfficeOpenXml;
using CrossFinance.Extensions;
using System.Web.Mvc;
using System;
using CrossFinance.XLSXReader;
using System.Collections.Generic;
using System.Linq;
using CrossFinance.Database;

namespace CrossFinance.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View(new MainViewModel());
        }

        [HttpPost]
        public ActionResult Index(MainViewModel model)
        {
            CrossFinanceDatabase database = new CrossFinanceDatabase(model);
            ObjectMapper objectMapper = new ObjectMapper();
            try
            {
                List<Person> persons = objectMapper.GetDataForObject(new Person(), model).Select(p => (Person)p).ToList();
                List<Address> addresses = objectMapper.GetDataForObject(new Address(), model).Select(a => (Address)a).ToList();
                List<FinancialState> financialStates = objectMapper.GetDataForObject(new FinancialState(), model).Select(f => (FinancialState)f).ToList();
                List<Agreement> agreements = objectMapper.GetDataForObject(new Agreement(), model).Select(a => (Agreement)a).ToList();
                database.InsertRows(persons, addresses, financialStates, agreements);
                return View(model);
            }
            catch (Exception ex)
            {
                if (model.ErrorList.Count != 0)
                {
                    return View(model);
                }
                model.ErrorList.Add("Unexpected error: "+ ex.ToString());
                return View(model);
            }


        }
    }
}