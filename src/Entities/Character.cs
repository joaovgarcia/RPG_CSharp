using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_POO_CS.src.Entities
{
    public class Character : Race
    {

        

        public Character()
        {

        }
        
        public Character(string name, int level, Race characterRace, Class characterClass)
        {
            this.Name = name;
            this.Level = level;
            this.CharacterClass = characterClass;
            this.CharacterRace = characterRace;
            
        }
        public string Name { get; set; }
        public int Level { get; set; }
        
        public Race CharacterRace { get; set; }
        public Class CharacterClass { get; set; }
        public List<Character> Characters { get; set; }       
    
    }
 
}












                    