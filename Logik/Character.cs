using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Character
    {
        string name { get; set; }
        string characterDescription { get; set; }
        int hitpoints { get; set; }
        int armor { get; set; }
        int attackdmg { get; set; }
        int speed { get; set; }
    }
}