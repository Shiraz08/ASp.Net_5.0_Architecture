﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAS_UI_Project.Controllers
{
    public class UniversityStudent : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
