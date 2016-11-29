using AvantPoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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



        [HttpPost]
        public ActionResult Copy(PolicyDetailsInfo model)
        {

            Thread.Sleep(5000);
            
            if (ModelState.IsValid)
            {
                // NOTE: Must clear the model state in order to bind
                //       the @Html helpers to the new model values
                ModelState.Clear();
            }

            return View("Index", model);

        }

        [HttpPost]
        public ActionResult Laps(PolicyDetailsInfo model)
        {
            if (ModelState.IsValid)
            {
                // NOTE: Must clear the model state in order to bind
                //       the @Html helpers to the new model values
                ModelState.Clear();
            }

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Issue(PolicyDetailsInfo model)
        {
            if (ModelState.IsValid)
            {
                // NOTE: Must clear the model state in order to bind
                //       the @Html helpers to the new model values
                ModelState.Clear();
            }

            return View("Index", model);
        }



    }
}