﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Areas.Emp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Emp/Default
        public ActionResult Index()
        {
            ViewBag.Desc = "Hello EMP";
            return View();
        }
    }
}