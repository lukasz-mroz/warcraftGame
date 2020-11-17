using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warcraftGame.Models;

namespace warcraftGame.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CharacterController : Controller
  {
    private static Character paladin = new Character();
    public IActionResult Index()
    {
      return Ok(paladin);
    }
  }
}
