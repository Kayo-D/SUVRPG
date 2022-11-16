using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUVRPG
{
    public class Spider : Character
    {
        bool hasPoisonSting;
        
        Combat Combat = new Combat();
        public Spider(string _name, int _level, int _hitpoints, ConsoleColor _color, int _armor, int _attackdmg, bool _hasPoisonSting) 
            : base(_name, _level, _hitpoints, _color, _armor, _attackdmg)
        {
            bool hasPoisonSting = _hasPoisonSting;
        }

        private void SpiderBite()
        {
            System.Console.WriteLine("The spider bites you");
            Combat.DealDamage(3);
        }
 
        public override void Attack(Character otherCharacter)
        {
            SpiderBite();
        }

    }
}