using BirthDayAppWithWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthDayAppWithWebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult InvitationPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InvitationPage(InvitationModel invitationModel)
        {
            if (ModelState.IsValid)
            {
                Database.add(invitationModel);
                return View("Thanks", invitationModel);
            }
            return View(invitationModel);
        }
        [ChildActionOnly]
        public ActionResult Attendees()
        {
            var attendees = Database.List.Where(i => i.Status == true).ToList();
            return PartialView(attendees);
        }
    }
}