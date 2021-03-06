﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        
        public string GetNumber(int id)
        {
            return id.ToString();
        }

        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy (Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);//додає інфу про покупку в БД
            db.SaveChanges();
            return "Дякуємо, " + purchase.Person + ", за покупку";


        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}