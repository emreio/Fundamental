﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["TestData"] = System.Diagnostics.Process.GetCurrentProcess().ProcessName + " ---9 " + Environment.MachineName;
            return View();
        }
    }
}
