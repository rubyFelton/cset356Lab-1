using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cset356Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            ViewBag.Person = "This is a person's information";
            return View();
        }
    }
}