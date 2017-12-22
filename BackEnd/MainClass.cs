using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Characters.NPC;
using static System.Console;

namespace BackEnd
{
    class MainClass
    {
        

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var helper = new Helper();
            var friend = new Friend();

            WriteLine(helper.Name);
            WriteLine(helper.Speak());

            WriteLine(friend.Name);
            WriteLine(friend.Speak());




            Read();
        }
    }
}
