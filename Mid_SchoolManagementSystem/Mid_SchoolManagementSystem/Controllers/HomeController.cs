using Mid_SchoolManagementSystem.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mid_SchoolManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        smsEntities data = new smsEntities();
        // GET: Home
        [HttpGet]
        public ActionResult HomeIndex()
        {
            generalnotice[] notice = data.generalnotice.ToArray();
            TempData["noticelist"] = notice;
            return View();
        }

        
    }
}