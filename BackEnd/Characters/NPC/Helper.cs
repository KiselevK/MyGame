using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Characters.NPC
{
    sealed class Helper :Character
    {
        public Helper()
        {
            Name = "Помощник";
            EstablishCharacteristics();
        }


        public override string Speak()
        {
            return "Привет путник\n" + "S = " + Strenght + " A = " + Agility + " I = " + Intellige;
        }

        public override void EstablishCharacteristics()
        {
            Strenght = 5;
            Agility = 6;
            Intellige = 5;
        }
    }
}
