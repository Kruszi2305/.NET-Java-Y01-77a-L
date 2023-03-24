using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appka259237_1
{
    internal class Przedmiot
    {
        private string item_name = " ";
        public string Name { get { return item_name;} set { item_name = value; } }

        private int item_value = 0;
        public int Value { get { return item_value;} set { item_value = value; } }

        private int item_weight = 0;
        public int Weight { get { return item_weight;} set { item_weight= value; } }

        private float item_value_to_weight_ratio = 0;
        public float ValueToWeightRatio { get { return item_value_to_weight_ratio; } set { item_value_to_weight_ratio = value; } }



    }
}
