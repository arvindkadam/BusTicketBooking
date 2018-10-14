using OnlineBusTicketBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBusTicketBooking.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            BusTicketBookingDBEntities db = new BusTicketBookingDBEntities();
            USER user = db.USERS.FirstOrDefault(x => x.ID == 1);
            UserViewModel usr = new UserViewModel
            {
                ID = user.ID,
                USER_NAME = user.USER_NAME,
                EMAIL = user.EMAIL
            };

            return View(usr);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}