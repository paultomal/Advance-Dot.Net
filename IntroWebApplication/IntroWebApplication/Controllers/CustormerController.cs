using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroWebApplication.Controllers
{
    public class CustormerController : Controller
    {
        // GET: Custormer
        public ActionResult Profile()
        {
            ViewBag.StudentName = "Paul Tamal";
            ViewBag.PhoneNo = "01743286902";
            ViewBag.Email = "tamal.paul.4213@gmail.com";
            ViewBag.LinkdIn = "https://www.linkedin.com/tamalpaul";
            
            ViewBag.Skill = "Web Design";
            ViewBag.Skill = "UI/UX";
            ViewBag.Skill = "Software Application";
            ViewBag.Skill = "Selenium";

            ViewBag.Language = "Bangla";
            ViewBag.Language = "English";
            ViewBag.Language = "Hindi";
             
            ViewData["Education"] = "BSc in CSE";
            ViewData["Campus"] = "AIUB";
            ViewData["Interest"] = "Gaming";
            ViewData["Interest1"] = "Traveling";
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
    }
}