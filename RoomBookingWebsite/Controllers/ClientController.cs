using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomBookingWebsite.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RoomBooking()
        {
            return View();
        }
        public ActionResult CancelBooking()
        {
            return View();
        }
        public ActionResult BookingDetails()
        {
            return View();
        }
        public ActionResult EditProfile()
        {
            return View();
        }
        public ActionResult ChangePassword()
        {
            return View();
        }

    }
}