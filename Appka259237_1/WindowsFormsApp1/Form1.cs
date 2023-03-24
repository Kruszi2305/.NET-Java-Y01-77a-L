using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appka259237_1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            int seed = 0;
            int num_of_items = 0;
            int max_capacity = 0;

            if (int.TryParse(number_of_itemsTextBox.Text, out result) == true) num_of_items = int.Parse(number_of_itemsTextBox.Text);
            if (int.TryParse(smallTextBox.Text, out result) == true) seed = int.Parse(smallTextBox.Text);
            if (int.TryParse(capacityTextBox.Text, out result) == true) max_capacity = int.Parse(capacityTextBox.Text);
            Backpack plecak = new Backpack(num_of_items, max_capacity, seed);
            if (radioButton_FastSort.Checked == true) plecak.FastSort();
            if (radioButton_BestValueSort.Checked == true) plecak.BestValueSort();
            if (radioButton_BestRatioSort.Checked == true) plecak.BestRatioSort();

            bigTextBox.Text = plecak.ToString();
        }

        private void smallTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
