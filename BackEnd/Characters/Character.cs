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

        public virtual string Speak()
        {
            return "Not released";
        }
    }
}
