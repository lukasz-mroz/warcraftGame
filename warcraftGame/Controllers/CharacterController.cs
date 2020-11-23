using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warcraftGame.Models;
using warcraftGame.Services;

namespace warcraftGame.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService)
    {
      _characterService = characterService;
    }

    [HttpGet("{id}")]
    public IActionResult GetSingle(int id)
    {
        return Ok(_characterService.GetCharacterById(id));

    }
    
    [HttpGet("GetAll")]
    public IActionResult Get()
    {
      return Ok(_characterService.GetAllCharacters());
    }

    [HttpPost]
    public IActionResult AddCharacter(Character newCharacter)
    {
      return Ok(_characterService);
    }
  }
}
