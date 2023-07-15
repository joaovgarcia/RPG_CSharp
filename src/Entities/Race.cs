using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG_POO_CS.src.Entities;

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



        public string RaceOption(string option) 
        {
            Game game = new Game();
            
            
                switch (option)
                {
                    case "HUMAN":
                        option = game.Texts(2);
                    break;

                    case "ELF":
                        option = game.Texts(4);
                    break;

                    case "ORC":
                        option = game.Texts(3);
                    break;


                    default: 
                         Console.WriteLine("It seems that this race hasn't been discovered yet!");
                    break;
                }
    
            return option;
        }


        
    }
}