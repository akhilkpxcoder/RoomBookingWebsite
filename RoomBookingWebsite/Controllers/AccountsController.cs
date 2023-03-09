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
            return View();
        }
        [HttpPost]
        public ActionResult Signin(ClientModel clientModel) 
        {
            AccountsService accountsService = new AccountsService();
            clientModel = accountsService.SigninService(clientModel.Username,clientModel.Password);
            if(clientModel.Username != null)
            {
                ViewBag.Message = "signin sucessfull";
            }           
            return View(); 
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(ClientModel clientModel)
        {
            AccountsService accountsService = new AccountsService();
            string result = accountsService.SignupService(clientModel);
            if (result == "User already exist")
            {
                ViewBag.Status = result.ToString();
                return View();
            }
            ViewBag.Status = result.ToString();
            return RedirectToAction("Index", "Client");
            
        }
    }
}