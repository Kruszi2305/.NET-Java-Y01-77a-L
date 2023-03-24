using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("UnitTestProject1"), InternalsVisibleTo("WindowsFormsApp1")]
namespace Appka259237_1
{
    internal class Backpack
    {
        public List<Przedmiot> Items = new List<Przedmiot>();
        public List<Przedmiot> ItemsInBackpack = new List<Przedmiot>();
        private int max_weight = 0;
        public  int MaxWeight { get { return max_weight; } set { max_weight = value; } }

        private int current_weight = 0;
        public  int CurrentWeight { get { return current_weight; } }

        private int number_of_itmes = 0;

        private int b_seed = 0;
        public int B_Seed { get { return b_seed; } }
        public Backpack(int num_of_items, int max_weight_limit,int seed)
        {
            this.max_weight = max_weight_limit;
            this.number_of_itmes=num_of_items;
            this.b_seed = seed;

            Generator rng = new Generator(seed);

            Console.WriteLine("Avalible items: ");
            for(int i = 0; i < num_of_items; i++)
            {
                Przedmiot buf_Item = new Przedmiot();
                buf_Item.Name = i.ToString();
                buf_Item.Value = rng.rand(1,100);
                buf_Item.Weight = rng.rand(1,20);

                buf_Item.ValueToWeightRatio = ((float)buf_Item.Value/(float)buf_Item.Weight);
                Console.WriteLine("Itme Name: " + buf_Item.Name + " Item Value: " + buf_Item.Value + " Item Weight: " + buf_Item.Weight + " Item V/W ratio: " + buf_Item.ValueToWeightRatio);
                this.Items.Add(buf_Item);
            }
        }
        public void Clear() { ItemsInBackpack.Clear(); current_weight = 0; Console.WriteLine("Backpack cleared..."); }

        public void Contents()
        {
            Console.WriteLine("Backpack contents: ");
            if (this.ItemsInBackpack.Count() == 0) Console.WriteLine("empty");
            for (int i = 0; i < this.ItemsInBackpack.Count(); i++)
            {
                Console.WriteLine("Itme Name: " + this.ItemsInBackpack[i].Name +
                                  " Item Value: " + this.ItemsInBackpack[i].Value +
                                  " Item Weight: " + this.ItemsInBackpack[i].Weight +
                                  " Item V/W ratio: " + this.ItemsInBackpack[i].ValueToWeightRatio);
            }

        }

        public override string ToString()
        {
            string msg = "";
            //Console.WriteLine("Backpack contents: ");

            msg += "Number of items: " + this.number_of_itmes + "\r\n";
            msg += "Backpack capacity: " + this.max_weight + "\r\n";
            msg += "Number of items: " + this.b_seed + "\r\n \r\n";
            msg += "Items avilable: \r\n";
            for (int i = 0; i < this.Items.Count(); i++)
            {
                msg += "Nr. : " + this.Items[i].Name +
                                  " V: " + this.Items[i].Value +
                                  " W: " + this.Items[i].Weight +
                                  " V/W: " + this.Items[i].ValueToWeightRatio + "\r\n";
            }
            msg += "Backpack contents: \r\n";
            if (this.ItemsInBackpack.Count() == 0) msg += "empty \r\n";
            for (int i = 0; i < this.ItemsInBackpack.Count(); i++)
            {
                msg +=            "Nr. : " + this.ItemsInBackpack[i].Name +
                                  " V: " + this.ItemsInBackpack[i].Value +
                                  " W: " + this.ItemsInBackpack[i].Weight +
                                  " V/W: " + this.ItemsInBackpack[i].ValueToWeightRatio + "\r\n";
            }
            return msg;
        }
        public void FastSort()
        {
            //Console.WriteLine("Fast Sort ");
            for(int i = 0; i < Items.Count() ; i++)
            {
                if (current_weight < max_weight)
                {
                    current_weight += Items[i].Weight;
                    if (current_weight > max_weight) { current_weight -= Items[i].Weight; continue; }
                    ItemsInBackpack.Add(Items[i]);
                }
            }
        }

        public void BestValueSort()
        {
            //Console.WriteLine("Best Value Sort");
            var orderByResult = from s in Items
                                orderby s.Value descending
                                select s;

            foreach (var item in orderByResult)
            {
                //Console.WriteLine("Itme Name: " + item.Name +
                //                  " Item Value: " + item.Value +
                //                  " Item Weight: " + item.Weight +
                //                  " Item V/W ratio: " + item.ValueToWeightRatio);
                current_weight += item.Weight;
                if(current_weight > max_weight) { current_weight -= item.Weight;  continue; }
                ItemsInBackpack.Add(item);
            }
        }

        public void BestRatioSort()
        {
            //Console.WriteLine("Best Ratio Sort ");
            var orderByResult = from s in Items
                                orderby s.ValueToWeightRatio descending
                                select s;

            foreach (var item in orderByResult)
            {
                if (current_weight < max_weight)
                {
                    current_weight += item.Weight;
                    if (current_weight > max_weight) { current_weight -= item.Weight; continue; }
                    ItemsInBackpack.Add(item);
                }
            }

  
        }

        public void PDSort()
        {
            //Console.WriteLine("PD Sort ");
            int[,] Matrix = new int[number_of_itmes+1, max_weight+1];
            for (int i = 0; i < max_weight +1; i++) Matrix[0, i] = 0;
            for (int i = 0; i < number_of_itmes + 1; i++) Matrix[i, 0] = 0;

            for (int i = 1; i < number_of_itmes + 1; i++)
            {
                Console.WriteLine(Items[i - 1].Name);
                for(int j = 1; j < max_weight+1; j++)
                {
                    if (Items[i - 1].Weight > j) { Matrix[i, j] = Matrix[i - 1, j]; }
                    if (Items[i - 1].Weight <= j) { Matrix[i,j] = Math.Max(Matrix[i - 1, j], Matrix[i - 1, j - Items[i - 1].Weight] + Items[i - 1].Value); }
                    //Matrix[i, j] = 0;
                }
            }
            //for (int i = 0; i < number_of_itmes + 1; i++)
            //{
            //    for (int j = 0; j < max_weight+1; j++)
            //    {
            //        Console.Write(Matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }

    }
}
