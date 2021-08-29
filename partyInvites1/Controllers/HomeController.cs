﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace partyInvites1.Controllers
{
    public class HomeController : Controller
    {
        
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Goot Afternoon";
            return View();
        }
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}