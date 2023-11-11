using MarketPlace.Data;
using MarketPlace.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MarketPlace.Controllers
{
    public class UserController : Controller

    {
        public IActionResult Register() //POST method for AddUser
        {
            var user = new User();
            var card = new CreditCard();
            var address = new Address();
            var model = (user, card, address);
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
