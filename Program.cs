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
            
            Character character = new Character();
            Game game = new Game();
            
        
            bool menu = true;
            while (menu)
            {   
                Console.Clear();
                Console.WriteLine(game.Texts(0));

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
   
                        character.NewCharacter();
                         
                    break;
                        
                }

            }

        }

 
    }
}

