using MarketPlace.Data;
using MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MarketPlace.Controllers
{
    public class UserController : Controller
    {
        private UserDbContext _db;

        public UserController(UserDbContext db)
        {
            _db = db;
        }
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User obj)
        {
            Random rnd = new Random();
            obj.UserId = rnd.Next(1000, 9999).ToString();
            var check = _db.Users.Find(obj.UserId);
            while (check != null) //in case random userid is already used
            {
                obj.UserId = rnd.Next(1000, 9999).ToString();
                check = _db.Users.Find(obj.UserId);
            }
            if (ModelState.IsValid)
            {
                if (_db.Users.Find(obj.UserId) == null)
                {
                    _db.Users.Add(obj);
                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
