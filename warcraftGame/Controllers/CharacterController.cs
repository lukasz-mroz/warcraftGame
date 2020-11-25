using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warcraftGame.Dtos;
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
    public async Task<IActionResult> GetSingle(int id)
    {
         return Ok(await _characterService.GetCharacterById(id));

    }
    
    [HttpGet("GetAll")]
    public async Task<IActionResult> Get()
    {
      return Ok(await _characterService.GetAllCharacters());
    }

    [HttpPost]
    public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
    {
      return Ok(await _characterService.AddCharacter(newCharacter));
    }
  }
}
