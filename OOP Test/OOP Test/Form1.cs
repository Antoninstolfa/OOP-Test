using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Test
{
    enum Oblicej
    {
        velkýnos, ušoplesk, makeup
    }
    enum Vlasy
    {
        drdol, culík, pleška
    }
    enum BarvaVlasu
    {
        kaštanová, blond, červená
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hrac hrac;
        private void button1_Click(object sender, EventArgs e)
        {
            Hrac hrac = new Hrac(textBox1.Text, comboBox1.SelectedIndex.ToString(), comboBox2.SelectedIndex, comboBox3.SelectedIndex, comboBox4.SelectedIndex);
            odpoved.Text = hrac.ToString();
        }
        
        private void Form1_Click(object sender, EventArgs e)
        {
            //hrac.ZmenaPozice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hrac.PridejXP(Convert.ToInt32(numericUpDown1.Value));
        }
    }
}
