﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Characters.NPC
{
    sealed class Friend:Character
    {
        public Friend()
        {
            Name = "Друг";
            EstablishCharacteristics();
        }
    }
}
