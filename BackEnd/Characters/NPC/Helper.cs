using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Characters.NPC
{
    class Helper :Character
    {
        public Helper()
        {
            Name = "Помощник";
        }


        public override string Speak()
        {
            return "Привет путник";
        }
    }
}
