using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Characters
{
    class Character : IStandartAction
    {
        
        
        public string Name { get; set; }

        public int Strenght { get; set; }
        public int Agility { get; set; }
        public int Intellige { get; set; }

        public virtual string Speak()
        {
            return "Not released!" + " S = " + Strenght + " A = " + Agility + " I = " + Intellige; 
        }

        public virtual void EstablishCharacteristics()
        {
            Strenght = 0;
            Agility = 0;
            Intellige = 0;
        }
    }
}
