using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Enemy : Character
    {
    public Enemy(string _name, int _level, int _hitpoints, string _characterDescription, ConsoleColor _color, int _armor, int _attackdmg, string _textArt)
    {
        string name = _name;
        int level = _level;
        int hitpoints = _hitpoints;
        int maxhitpoints = _hitpoints;
        string characterDescription = _characterDescription;
        ConsoleColor color = _color;
        int armor = _armor;
        int attackdmg = _attackdmg;
        string textArt = _textArt;
        RandGenerator = new Random();   
    }
    }
}