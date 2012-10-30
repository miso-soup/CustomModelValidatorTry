using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomModelValidatorTry.Models;

namespace CustomModelValidatorTry.Controllers
{
    public class PersonController : Controller
    {
		[HttpGet]
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
        public ActionResult Create()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Create(Person person)
		{
			if (!ModelState.IsValid)
				return View(person);

			return RedirectToAction("Index");
		}
    }
}
