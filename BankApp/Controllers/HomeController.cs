using BankApp.Models.DB_Model;
using BankApp.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StaffApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(NewStaff newCustomer)
        {
            try
            {
                var db = new Model1();
                var cust = new Customer();
                cust.Firstname = newCustomer.FirstName;
                cust.Lastname = newCustomer.LastName;
                cust.DOB = newCustomer.DOB;
                cust.Regdate = DateTime.UtcNow.AddHours(1);
                db.Customers.Add(cust);
                db.SaveChanges();
                return View();
            }
            catch (Exception Ex)
            {

                ViewBag.ErrorMessage = "An Error Occurred during Registration";
                return View();
            }
        }

        public ActionResult SuccessfulReg()
        {
            return View();
        }
    }
}