using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG_POO_CS.src.Entities;

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


        public Character NewCharacter()
        {   
            
            List<Character> characterList = new List<Character>();
            Game game = new Game();
            Character newCharacter = new Character();
            
            string[] key = new string[2]{"n", "n"};
            do 
            {  

                    if (key[0] != "y" && key[1] == "n")
                    {
                        Console.WriteLine(game.Texts(1));
                        newCharacter.RaceName = Console.ReadLine().ToUpper();
                        Console.WriteLine(newCharacter.RaceOption(newCharacter.RaceName));
                        key[0] = Console.ReadLine();


                    }

                    else if (key[0] == "y" && key[1] != "y" ) 
                    {
                        Console.WriteLine(game.Texts(6));
                        newCharacter.ClassName = Console.ReadLine().ToUpper();
                        Console.WriteLine(newCharacter.ClassOption(newCharacter.ClassName));
                        key[1] = Console.ReadLine();
                        
                            if (key[0] == "y" && key[1] == "y")
                            {

                                Console.WriteLine(game.Texts(10));
                                newCharacter.Name = Console.ReadLine();
                                Console.WriteLine(game.Texts(11 ,newCharacter.Name));
                                Console.ReadLine();
                            
                            }
                    
                    }
                    
                    
                    
                   
                
            }while(key[0] != "y" || key[1] != "y");

            characterList.Add(newCharacter);

            return newCharacter;
        
        }   
    
    }
 
}












                    