﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SisMed.Models;

namespace SisMed.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}