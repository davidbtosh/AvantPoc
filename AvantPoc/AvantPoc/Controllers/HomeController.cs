using AvantPoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AvantPoc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PolicyDetailsInfo model = new PolicyDetailsInfo();
            model.CreateMockData();

            return View(model);
        }
    }
}