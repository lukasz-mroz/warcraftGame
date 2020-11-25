﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warcraftGame.Dtos;
using warcraftGame.Models;

namespace warcraftGame.Services
{
  public class CharacterService : ICharacterService
  {
    private static List<Character> characters = new List<Character>
    {
      new Character(),
      new Character{ Id = 1, Name = "Sam"}
    };
    public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
      characters.Add(newCharacter);
      serviceResponse.Data = characters;
      return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
      serviceResponse.Data = characters;
      return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
    {
      var serviceResponse = new ServiceResponse<GetCharacterDto>();
      serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
      return serviceResponse;
    }
  }
}
