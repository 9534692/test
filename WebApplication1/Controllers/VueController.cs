﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class VueController : Controller
    {
        // GET: Vue
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1() {
            return View();
        }
    }
}