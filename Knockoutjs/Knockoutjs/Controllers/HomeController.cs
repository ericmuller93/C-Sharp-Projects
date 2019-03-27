using Knockoutjs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Knockoutjs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Names names = new Names();
            string firstname = names.FirstName;
            string lastname = names.LastName;

            return View();
        }
    }
}