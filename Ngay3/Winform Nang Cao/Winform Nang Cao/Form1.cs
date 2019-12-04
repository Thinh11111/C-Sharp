using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Nang_Cao
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            txtShow.Text = nudChose.Value.ToString();
        }

        private void TxtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClickme_Click(object sender, EventArgs e)
        {
            string kq = "";

            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                kq = kq + comboBox1.GetItemText(comboBox1.Items[i]) + "\n";
            }
            MessageBox.Show(kq, "Kết Quả", MessageBoxButtons.OK);
        }

        private void BtnClickme2_Click(object sender, EventArgs e)
        {
            string kq = "";
            //foreach(Object ob in ltbThu.SelectedItems)
            //{
            //    kq = kq + ob.ToString()+"\n";
            //}
            for (int i = 0; i < ltbThu.Items.Count; i++)
            {
                kq = kq + ltbThu.GetItemText(ltbThu.Items[i]) + "\n";
            }

            MessageBox.Show(kq);

        }

        private void LtbThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
