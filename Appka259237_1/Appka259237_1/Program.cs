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

            Generator rng = new Generator();
            List<int> arr = new List<int>();
            List<Przedmiot> przedmioty = new List<Przedmiot>();
            string[] item_name = {"TV", "XBox ONE", "PS5", "NSwitch", "Radio" , "Smartphone", "Headphones", }

            for (int i = 0; i < 10; i++)
            {
                arr.Add(rng.rand(0, 10));
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();
        }

    }
}