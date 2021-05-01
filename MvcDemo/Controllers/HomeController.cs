using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id, string name)
        {
            return "Id = " + id + "Name = " + name;
        }

        public string GetDetails()
        {
            return "GetDetails Invoked";
        }

        public ViewResult New()
        {
           ViewBag.Countries =  new List<string>()
            {
                "Sri Lanka",
                "Usa",
                "India",
                "Australia"
            };
            return View();
        }

    }
}