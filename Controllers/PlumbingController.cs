﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Controllers
{
    public class PlumbingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
