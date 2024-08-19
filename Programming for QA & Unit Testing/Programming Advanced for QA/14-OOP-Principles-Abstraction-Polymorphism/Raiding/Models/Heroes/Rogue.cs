using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Heroes
{
    public class Rogue : Fighter
    {
        public Rogue(string name) : base(name)
        {
            Power = 80;
        }

        public override int Power { get; }
        public override string CastAbility()
        {
            return $"{base.CastAbility()}";
        }
    }
}
