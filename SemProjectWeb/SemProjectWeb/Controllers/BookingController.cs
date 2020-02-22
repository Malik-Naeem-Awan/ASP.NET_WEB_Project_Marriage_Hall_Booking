using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SemProjectWeb.Models;


namespace SemProjectWeb.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking

        [HttpGet]
        public ActionResult booking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult booking(BookingTable userModel)
        {
            using (DbModels dbModel =new DbModels())
            {
                BookingTable data = new BookingTable();

                if (dbModel.Users.Any(x => x.UserEmail == userModel.User_Email))
                {

                        dbModel.BookingTables.Add(userModel);

                        dbModel.SaveChanges();
                    //return View("Registeration", userModel);
                    return RedirectToAction("index", "Home");
                }
                
            }
            ModelState.Clear();
            //return View("Registeration", new User());
            return RedirectToAction("Booking", "Booking");
        }


    }
}