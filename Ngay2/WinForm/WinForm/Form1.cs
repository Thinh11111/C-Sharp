using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "This is my first Lable";
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.TextAlign = ContentAlignment.MiddleCenter;

            textBox1.Text = "Demo";

            textBox1.Width = 250;
            textBox1.Height = 50;

            textBox1.BackColor = Color.DarkOrange;
            textBox1.ForeColor = Color.White;

            button1.Text = "Click Me";
            button1.Image = Image.FromFile(@"..\..\Images\testImage.jpg");
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("You press Enter key");
            }
            if (e.KeyCode == Keys.CapsLock)
            {
                MessageBox.Show("You press CapsLock key");
            }

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Demo");
        }
    }
}
