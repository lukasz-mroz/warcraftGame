﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warcraftGame.Controllers
{
  [ApiController]
  [Route("[controller")]
  public class CharacterController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
