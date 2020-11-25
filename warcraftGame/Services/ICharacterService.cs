using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warcraftGame.Dtos;
using warcraftGame.Models;


namespace warcraftGame.Services
{
  public interface ICharacterService
  {
    Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
    Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
    Task<ServiceResponse<List<AddCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
  }
}
