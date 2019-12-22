using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhucLong
{
    public partial class frm_Logout : Form
    {
        public frm_Logout()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Có Muốn Thoát", "Thông Báo");
            frm_Login f = new frm_Login();
            this.Hide();
            f.ShowDialog();
            this.Show();
            f.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            panelQLBH.Visible = false;
            panelThongKe.Visible = false;
            panelQLNV.Visible = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelThongKe.Visible = false;
            panelQLNV.Visible = false;
            panelQLBH.Visible = true;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void frm_Logout_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelQLNV.Visible = false;
            panelQLBH.Visible = true;
            panelThongKe.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want log out !", "Thong Bao ");
            this.Hide();
            frm_Login f = new frm_Login();
            f.ShowDialog();
            this.Close();
        }
    }
}
