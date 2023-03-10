using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Appka259237_1
{
    internal class Generator
    {
        int Seed;

        public Generator()
        {
            this.Seed = 1;
        }
        public Generator(int new_seed)
        {
            this.Seed = new_seed;
        }

        Random random_num = new Random();
        public int rand(int low, int high)
        {
            return random_num.Next(low, high);
        }
        public override string ToString()
        {
            int x = 1;
            string str = "tekst" + x.ToString() + "tekst";
            return "to jest generator";
        }
    }
}
