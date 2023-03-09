using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoomBookingWebsite.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Signin()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
    }
}