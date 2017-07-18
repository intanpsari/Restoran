using Restoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Controllers
{
    public class HomeController : Controller
    {
        private OperationDataContext context = null;
        public HomeController()
        {
            context = new OperationDataContext();
        }

        // GET: Home
        public ActionResult Login(HomeModel model)
        {
            var q = from p in context.tusers
                    where p.username == model.username
                    && p.password == model.password
                    select p;
            if (q.Any())
            {
                return RedirectToAction("Index", "Order");
            }
            else if (model.username=="admin" && model.password=="admin")
            {
                return RedirectToAction("Data", "Menu");
            }
            else
            {
                
                return View("Login");
            }
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}