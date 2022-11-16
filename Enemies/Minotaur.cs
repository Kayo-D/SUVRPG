using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Minotaur : Character
    {
        Combat Combat = new Combat();
        public Minotaur(string _name, int _level, int _hitpoints, ConsoleColor _color, int _armor, int _attackdmg) 
            : base(_name, _level, _hitpoints, _color, _armor, _attackdmg)
        {
            
        }

        private void MinoSmash()
        {
            System.Console.WriteLine("The minotaur smashes at you!");
            Combat.DealDamage(6);
        }
 
        public override void Attack(Character otherCharacter)
        {
            MinoSmash();
        }

    }
}