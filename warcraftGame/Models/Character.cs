using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace warcraftGame.Models
{
  public class Character
  {
    public int Id { get; set; }
    public string Name { get; set; } = "Arthas";
    public int Level { get; set; } = 1;
    public ClassCharacter ClassType { get; set; } = ClassCharacter.Paladin;
  }
}
