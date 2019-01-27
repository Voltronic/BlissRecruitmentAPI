using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlissRecruitmentAPI.Controllers
{
    /// <summary>
    /// BlissRecruitmentAPI Home controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// BlissRecruitmentAPI Home controller - Index action
        /// </summary>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
