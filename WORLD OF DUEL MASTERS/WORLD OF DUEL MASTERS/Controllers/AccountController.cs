using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WORLD_OF_DUEL_MASTERS.Models;


namespace WORLD_OF_DUEL_MASTERS.Controllers
{
    public class AccountController : Controller
    {

        private readonly MyDatabaseContext _accountcontext;


        public AccountController(MyDatabaseContext context)
        {
            _accountcontext = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

       

        [HttpPost]
        public ActionResult Register(Account account)
        {
            HttpContext.Session.SetString("UserName", "qwe");
            if (ModelState.IsValid)
            {
                account.Type = "User";
                _accountcontext.Add(account);
                _accountcontext.SaveChanges();
                ModelState.Clear();
                return RedirectToAction(nameof(SuccesfullyRegistered));

            }
            return View();
        }

        public IActionResult SuccesfullyRegistered()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account acc)
        {
            if (acc.Username=="Admin"&& acc.Password == "Admin")
            {
                HttpContext.Session.SetString("UserName", acc.Username);
                HttpContext.Session.SetString("Password", acc.Password);
                return RedirectToAction("Index","Admin");
            }
            if (acc.Username != null && acc.Password != null)
            {
                var searchforacc = _accountcontext.Accounts.Where(a => a.Username.Equals(acc.Username) && a.Password.Equals(acc.Password)).FirstOrDefault();
                if (searchforacc != null)
                {
                    HttpContext.Session.SetString("UserName", searchforacc.Username);
                    HttpContext.Session.SetString("Password", acc.Password);
                   
                    return RedirectToAction("UserDashBoard");

                }
                else
                {
                    return RedirectToAction("Login");
                }
            }
            return RedirectToAction("Login");

        }
        public ActionResult UserDashBoard()
        {

                return RedirectToAction("DashBoardUser", "User");


        }

        public ActionResult Logout(Account acc)
        {
            if (HttpContext.Session.GetString("UserName") != null && HttpContext.Session.GetString("Password") != null)
            {
                HttpContext.Session.SetString("UserName", "");
                HttpContext.Session.SetString("Password", "");
            }
            return RedirectToAction("HomePage", "Guest");
        }
    }
}