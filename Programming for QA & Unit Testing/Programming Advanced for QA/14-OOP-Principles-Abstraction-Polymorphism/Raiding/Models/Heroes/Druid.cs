using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Heroes
{
    public class Druid : Healer
    {
        public Druid(string name) : base(name)
        {
            
        }

        public override int Power { get => 80 ; }
        public override string CastAbility()
        {
            return $"{base.CastAbility()}";   
        }
    }
}
