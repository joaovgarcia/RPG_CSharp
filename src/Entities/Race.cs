using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_POO_CS.src.Entities
{
    public abstract class Race : Class
    {   
        public Race()
        {

        }

        public Race(string raceName, string hability)
        {
            this.RaceName = raceName;
            this.Hability = hability;
        }
        public string RaceName { get; set; }
        public string Hability{ get; set; }


        
    }
}