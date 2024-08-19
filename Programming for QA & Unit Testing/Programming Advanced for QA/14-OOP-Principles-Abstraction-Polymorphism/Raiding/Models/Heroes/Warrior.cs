using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Heroes
{
    public class Warrior : Fighter
    {
        public Warrior(string name) : base(name)
        {
            Power = 100;
        }

        public override int Power { get; }
        public override string CastAbility()
        {
            return $"{base.CastAbility()}";
        }
    }
}
