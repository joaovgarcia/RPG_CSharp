using System.Data;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using RPG_POO_CS.src.Entities;

namespace RPG_POO_CS
{
    class Program
    {
       
        static void Main(string[] args)
        {   
            List<Character> characterList = new List<Character>();
            Program methods = new Program();
            
        
            bool menu = true;
            while (menu)
            {   
                Console.Clear();
                Console.WriteLine(methods.Texts(0));

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
   
                        methods.NewCharacter();
                         
                    break;


                        
                }

            }

        }

        public Character  CharacterList(string characterName)
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

        public Character NewCharacter()
        {   
            
            List<Character> characterList = new List<Character>();
            Program methods = new Program();
            Character newCharacter = new Character();
            
            string[] YESorNO = new string[2];
            do 
            {   
                    
                    if (YESorNO[0] == "YES") 
                    {

                        Console.WriteLine(methods.Texts(1));
                        newCharacter.RaceName = Console.ReadLine().ToUpper();
                        Console.WriteLine(methods.RaceOption(newCharacter.RaceName));
                        YESorNO[0] = Console.ReadLine().ToUpper();

                            

                    }
                    else if (YESorNO[0] == "YES" && YESorNO[1] != "YES")
                    {

                        Console.WriteLine(methods.Texts(6));
                        newCharacter.ClassName = Console.ReadLine().ToUpper();
                        Console.WriteLine(methods.ClassOption(newCharacter.ClassName));
                        YESorNO[1] = Console.ReadLine().ToUpper();

                            if (YESorNO[0] == "YES" && YESorNO[1] == "YES")
                            {

                                Console.WriteLine(methods.Texts(10));
                                newCharacter.Name = Console.ReadLine();
                                Console.WriteLine(methods.Texts(11 ,newCharacter.Name));
                                Console.ReadLine();
                                
                                
                                
                    
                            }

                    }

                
            }while(YESorNO[0] != "YES"  || YESorNO[1] != "YES");

            characterList.Add(newCharacter);

            return newCharacter;
        
        }
        public string RaceOption(string option) 
        {
            Program methods = new Program();
            
            
                switch (option)
                {
                    case "HUMAN":
                        option = methods.Texts(2);
                    break;

                    case "ELF":
                        option = methods.Texts(4);
                    break;

                    case "ORC":
                        option = methods.Texts(3);
                    break;


                    default: 
                         Console.WriteLine("It seems that this class hasn't been discovered yet!");
                    break;
                }
    
            return option;
        }  

        public string ClassOption(string option) 
        {
            Program methods = new Program();
            
                switch (option)
                {
                    case "THIEF":
                        option = methods.Texts(7);
                    break;

                    case "MAGE":
                        option = methods.Texts(9);
                    break;

                    case "KNIGHT":
                        option = methods.Texts(8);
                    break;


                    default: 
                         Console.WriteLine("It seems that this class hasn't been discovered yet!");
                    break;
                }
    
            return option;
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
                            "To select Human type: yes. to go back press any key.";


                texts[3] =  "Orcs are trusty and honorable creatures,\n" +
                            "Guided by glory, they seek it with strenght\n" +
                            "They're known to be very competitive, and a deal\n" +
                            "With them, is a deal with them!\n\n" +
                            "Their hability Rage significantly increases\n" +
                            "Strengh, damage and atack speed.\n\n\n" +
                            "To select Orc type: yes. to go back press any key.";


                            
                texts[4] =  "Elves are elegant in everything they do\n" +
                            "Seeking peace and perfection in every detail\n" +
                            "Most known for their reliability, that goes to\n" +
                            "Full devoted to betraeyr and enemy\n\n" +
                            "Their hability Grace highly increases their" +
                            "Speed, agility and critical.\n\n\n" +
                            "To select Elf type: yes. to go back press any key.";

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

                           "To select Thief Human type: yes. to go back press any key.";

                texts[8] = "By honor, to fulfil the duty and for the prize!\n" +
                           "Endurance, Charisma, wears heavy armor, and can\n" +
                           "Swing any piece of metal while looking cool\n" +
                           "And dealing a great damage.\n\n" +

                           "Comes with a Long Steel Sword, a Very Heavy Iron Armor...\n" +
                           "Knights can be very resiliant when in a mission for their\n" +
                           "Lady or Master, knowing that fail is not an option\n" +
                           "Can recover half of their life and a boost of regeneration\n" +
                           "In moments of need\n\n" +

                           "To select Knight type: yes. to go back press any key.";

                texts[9] = "In order to know, only by knowing, the pure knowledge\n" +
                           "Intelligence, power, is just the result in the way of\n" +
                           "Knowledge, wears light robes\n\n" +

                           "Comes with a Wind Staff, a Basic Robe\n" +
                           "Mages are solitaries and uncomprehensible, with many misteryes\n" +
                           "That they also don't know long term results of some spells and\n" +
                           "Encantations. Significantly increases mana regenetation, while\n" +
                           "Converts all the damage to mana.\n\n" +

                           "To select Mage type: yes. to go back press any key.";

                texts[10] = "Very well them! Now, tell me your name...";

                texts[11] = $"Nice to meet you {name}, this conversation was really good, but i have to kill you ...";
                
            
                return texts[option];
     
        }        
        
    }
}

