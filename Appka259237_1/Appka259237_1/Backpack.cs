using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Appka259237_1
{
    internal class Backpack
    {
        public List<string> item_name  = new List<string>();
        public List<int> item_value = new List<int>();
        public List<int> item_mass = new List<int>();
        public List<int> val_to_mass_ratio = new List<int>();

        private int max_weight;

        public Backpack(int num_of_items, int max_weight_limit,int seed)
        {
            this.max_weight = max_weight_limit;
        
            Generator rng = new Generator();
            for(int i = 0; i < num_of_items; i++)
            {
                item_name.Add("Przedmiot nr." + i.ToString() + "/n");
                item_value.Add(rng.rand(0,100));
                item_mass.Add(rng.rand(1,20));
                Console.WriteLine("Item name / Item value / Item mass");
                Console.WriteLine(item_name[i] + " " + item_value[i] + " " + item_mass[i]);
                
            }
        }
        public
    }
}
