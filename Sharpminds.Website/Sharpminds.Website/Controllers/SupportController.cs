using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sharpminds.Website.Controllers
{
    public class SupportController : Controller
    {
        //
        // GET: /Support/

        public ActionResult Support()
        {
            ViewBag.Message = "Support section for our customers. To come soon.";

            return View();
        }

    }
}
