using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warcraftGame.Models;

namespace warcraftGame.Dtos
{
  public class AddCharacterDto
  {
    public string Name { get; set; } = "Arthas";
    public int Level { get; set; } = 1;
    public ClassCharacter ClassType { get; set; } = ClassCharacter.Paladin;
  }
}
