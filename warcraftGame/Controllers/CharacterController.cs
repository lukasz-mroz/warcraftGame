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
    private static List<Character> characters = new List<Character>
    {
      new Character(),
      new Character{Id = 1, Name = "Sam"}
    };

    [HttpGet("{id}")]
    public IActionResult GetSingle(int id)
    {
      return Ok(characters.FirstOrDefault(c => c.Id == id));
    }
    
    [HttpGet("GetAll")]
    public IActionResult Get()
    {
      return Ok(characters);
    }

    [HttpPost]
    public IActionResult AddCharacter(Character newCharacter)
    {
      characters.Add(newCharacter);
      return Ok(characters);
    }
  }
}
