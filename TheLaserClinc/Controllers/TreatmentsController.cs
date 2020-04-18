using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheLaserClinc.Controllers
{
    public class TreatmentsController : Controller
    {
    
        public ActionResult LaserHairRemoval()
        {
            ViewBag.Title = "Laser Hair Removal";

            return View();
        }

        public ActionResult Acne()
        {
            ViewBag.Title = "Laser Hair Removal";

            return View();
        }

        public ActionResult PigmentationRemoval()
        {
            ViewBag.Title = "Pigmentation Removal";

            return View();
        }

        public ActionResult VascularTreatment()
        {
            ViewBag.Treatment = "Vascular Treatment";

            return View();
        }

        public ActionResult SkinRejuvenation()
        {
            ViewBag.Treatment = "Vascular Treatment";

            return View();
        }

        public ActionResult RemodelRadioFrequency()
        {
            ViewBag.Treatment = "Remodel RF (Radio Frequency)";

            return View();
        }

        public ActionResult ResurfaceFractionalLaser()
        {
            ViewBag.Treatment = "Resurface Fractional Laser";

            return View();
        }
    }
}