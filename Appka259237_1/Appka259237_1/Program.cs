using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appka259237_1
{
    class ProgramRNG
    {
        static void Main(string[] args)
        {

            Backpack plecak = new Backpack(5, 20, 23045231);
            plecak.PDSort();

            //string[] item_name = {"TV", "XBox ONE", "PS5", "NSwitch", "Radio" , "Smartphone", "Headphones", }


            Console.Read();
        }

    }
}