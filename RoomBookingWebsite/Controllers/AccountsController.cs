using RoomBookingWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using RoomBookingWebsite.Models;

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
            ClientModel clientModel =new ClientModel();
            AccountsService accountsService = new AccountsService();
            clientModel.UserType = accountsService.SigninService("akhil", "akhil123");
            return View(clientModel);
        }
        public ActionResult Signup()
        {
            return View();
        }
    }
}