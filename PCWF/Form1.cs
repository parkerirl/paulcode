using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCWF
{
    public partial class Form1 : Form
    {
        int Range_1, Range_2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int convValue = Convert.ToInt32(textBox1.Text);
            Range_1 = convValue;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int convValue = Convert.ToInt32(textBox2.Text);
            Range_2 = convValue;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            performAnalysis();
        }

        private void performAnalysis()
        {
            int[] Scale_1 = new int[Range_1];
            string[] TempScale_1 = new string[Range_1];
            TempScale_1 = textBox3.Text.Split(',');
            for (int i = 0; i < Range_1; i++)
            {
                Scale_1[i] = Convert.ToInt32(TempScale_1[i]);
            }

            int[] Scale_2 = new int[Range_2];
            string[] TempScale_2 = new string[Range_2];
            TempScale_2 = textBox4.Text.Split(',');
            for (int i = 0; i < Range_2; i++)
            {
                Scale_2[i] = Convert.ToInt32(TempScale_2[i]);
            }

            int Slot_1 = 0, Slot_2 = 0;
            for (int j = 0; j < 256; j++)
            {

                if (Scale_1[Slot_1] == Scale_2[Slot_2])
                {
                    label5.Text = "MATCH AT:";
                    label6.Text = $"Scale 1 degree: {Slot_1} | pitch: {Scale_1[Slot_1]}";
                    label7.Text = $"Scale 2 degree: {Slot_2} | pitch: {Scale_2[Slot_2]}";
                }
                /*else
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Scale 1 degree: {Slot_1} | pitch: {Scale_1[Slot_1]}");
                    Console.WriteLine($"Scale 2 degree: {Slot_2} | pitch: {Scale_2[Slot_2]}");
                }*/

                Slot_1++;
                Slot_2++;
                if (Slot_1 >= Range_1) Slot_1 = 0;
                if (Slot_2 >= Range_2) Slot_2 = 0;
            }
        }
    }
}
