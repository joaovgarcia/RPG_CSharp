using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG_POO_CS.src.Entities;

namespace RPG_POO_CS.src.Entities
{
    public class Game
    {

            public Character CharacterList(string characterName)
            {
                List<Character> characterList = new List<Character>();
                Character character = null;

                for (int i = 0; i < characterList.Count; i++)
                {
                     

                     if (characterList[i].Name.ToUpper() == characterName.ToUpper())
                     {
                        character = characterList[i];
                        break;
                     }
                     else
                     {
                        Console.WriteLine(characterList[i].Name);
                     }
                }

                return character;
            }


       public string Texts(int option, string name = "")
        {

        
            
            String[] texts = new String[999]; 

            Console.Clear();
                texts[0] =  "Welcome to Abstractus! \n" +
                            "A RPG game made in C# \n" +
                            "In order to study OOP \n" +
                            "\n\n" +
                            "Choose an option:\n" +
                            "1 - New Character\n" +
                            "2 - Characters\n" +
                            "3 - Classes\n" +
                            "4 - Races \n" +
                            "5 - Quit";

                texts[1] =  "Very good, now select your player's race!\n" +
                            "Note that, each race comes with a singular hability\n" +
                            "That can be seen right after chosing. And, do not worry\n" +
                            "You can come back to the race selection!\n\n" +
                            "You can select your race by typing it and hit enter\n\n\n" +
                            "Race/Hability: -- Human/Motivation -- Orc/Rage -- Elf/Dance Grace --";
                           

                texts[2] =  "Humans are warm hearted creatures,\n" +
                            "Fully emotional, with many layers of humanity\n" +
                            "Humans are known by their charism and egoistic way\n" +
                            "To see the world.\n\n" +
                            "Their hability Motivation makes any human around\n" +
                            "Gain extra life, armor and wisdom.\n\n\n" +
                            "To select Human type: y. to go back type: n.";


                texts[3] =  "Orcs are trusty and honorable creatures,\n" +
                            "Guided by glory, they seek it with strenght\n" +
                            "They're known to be very competitive, and a deal\n" +
                            "With them, is a deal with them!\n\n" +
                            "Their hability Rage significantly increases\n" +
                            "Strengh, damage and atack speed.\n\n\n" +
                            "To select Orc type: y. to go back type: n.";


                            
                texts[4] =  "Elves are elegant in everything they do\n" +
                            "Seeking peace and perfection in every detail\n" +
                            "Most known for their reliability, that goes to\n" +
                            "Full devoted to betraeyr and enemy\n\n" +
                            "Their hability Grace highly increases their" +
                            "Speed, agility and critical.\n\n\n" +
                            "To select Elf type: y. to go back type: n.";

                texts[5] = "Now choose your way to battle!\n" +
                           "Choose your Class!";

                texts[6] = "The same way you choose the race you may choose" +
                           "Choose your class.\n\n" +
                           "-- Thief -- Knight -- Mage -- ";
                
                texts[7] = "Not that they will stole your gold, scary you up\n" +
                           "Or something. But that means that they are very\n" +
                           "Furtive, sneaky, wears light armor, and know\n" +
                           "How to use a dagger... Well, they might steal\n" +
                           "Somenthing from you.\n\n" +

                           "Comes with a Sharp Steel Dagger, a Very Light\n" +
                           "Fur armor... Thieves are known to lie upon the shadow\n" +
                           "Blessing of the New Moon, guaranting them Invisibility\n" +
                           "In moments of need.\n\n" +

                           "To select Thief Human type: y2. to go back type: n.";

                texts[8] = "By honor, to fulfil the duty and for the prize!\n" +
                           "Endurance, Charisma, wears heavy armor, and can\n" +
                           "Swing any piece of metal while looking cool\n" +
                           "And dealing a great damage.\n\n" +

                           "Comes with a Long Steel Sword, a Very Heavy Iron Armor...\n" +
                           "Knights can be very resiliant when in a mission for their\n" +
                           "Lady or Master, knowing that fail is not an option\n" +
                           "Can recover half of their life and a boost of regeneration\n" +
                           "In moments of need\n\n" +

                           "To select Knight type: y. to go back type: n.";

                texts[9] = "In order to know, only by knowing, the pure knowledge\n" +
                           "Intelligence, power, is just the result in the way of\n" +
                           "Knowledge, wears light robes\n\n" +

                           "Comes with a Wind Staff, a Basic Robe\n" +
                           "Mages are solitaries and uncomprehensible, with many misteryes\n" +
                           "That they also don't know long term results of some spells and\n" +
                           "Encantations. Significantly increases mana regenetation, while\n" +
                           "Converts all the damage to mana.\n\n" +

                           "To select Mage type: y. to go back type: n.";

                texts[10] = "Very well them! Now, tell me your name...";

                texts[11] = $"Nice to meet you {name}, this conversation was really good, but i have to kill you ...";
                
            
                return texts[option];
     
        }         
    }
}