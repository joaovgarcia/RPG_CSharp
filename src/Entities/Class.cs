using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace RPG_POO_CS.src.Entities
{
    public abstract class Class
    {   

        public Class()
        {

        }

        public Class(string className, string weapon, string bless, string armor)
        {
            this.ClassName = className;
            this.Weapon = weapon;
            this.Armor = armor;
            this.Bless = bless;
        }
      
        public string ClassName { get; set; }
        public string Weapon { get; set; }
        public string Bless { get; set; }
        public string Armor { get; set; }
   
        
        public virtual void ClassStats(string className, string weapon, string bless, string armor)
        {   
            this.ClassName = className;
            this.Weapon = weapon;
            this.Bless = bless;
            this.Armor = armor;
        }

        public virtual void Attack()
        {

        }

  
    }
}