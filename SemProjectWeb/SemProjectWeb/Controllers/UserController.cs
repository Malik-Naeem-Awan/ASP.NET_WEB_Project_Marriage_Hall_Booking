using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using SemProjectWeb.Models;

namespace SemProjectWeb.Controllers
{
    public class UserController : Controller
    {
        
        // GET: User
        [HttpGet]
        public ActionResult SignUp(int id=0)
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult SignUp(User userModel)
        {
            using (DbModels dbModel = new DbModels())
            {
                if (dbModel.Users.Any(x => x.UserName == userModel.UserName))
                 {
                    ViewBag.DuplicateMessage = "UserName Already Exists!";
                    
                    return View("SignUp", userModel);
                }
                if (dbModel.Users.Any(x => x.UserEmail == userModel.UserEmail))
                {
                    ViewBag.DuplicateMessage = "Email Already Exists!";
                    
                    return View("SignUp", userModel);
                }
                dbModel.Users.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registeration Success!";
            return View("SignUp", new User());

        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User userModel)
        {
            using (DbModels dbModel = new DbModels())
            {
                if (dbModel.Users.Any(x => x.UserEmail == userModel.UserEmail && x.Password == userModel.Password))
                {
                    ModelState.Clear();
                    ViewBag.SuccessMessage = "Login Success!";
                        return RedirectToAction("Booking", "Booking");
                }
                
                ViewBag.FailedLogin = "Login UnSuccess!";
                return View();
            }
        }
    }
}