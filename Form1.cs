using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renklerin_Dili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            label3.Visible = true;
            if (comboBox1.Text == "Mavi")
            {
                label3.Text = "Hey" + " " + textBox1.Text + " " + comboBox1.Text + " " + "rengi" + " " + "huzurun rengidir ";
                button2.BackColor = Color.Blue;
            }

            if (comboBox1.Text == "Beyaz")
            {
                label3.Text = "Hey" + " " + textBox1.Text + " " + comboBox1.Text + " " + "rengi" + " " + "masumiyetin rengidir";
                button2.BackColor = Color.White;
            }

            if (comboBox1.Text == "Sarı")
            {
                label3.Text = "Hey" + " " + textBox1.Text + " " + comboBox1.Text + " " + "rengi" + " " + "eğlencenin rengidir";
                button2.BackColor = Color.Yellow;
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            label3.Visible = false;
        }
    }
}
