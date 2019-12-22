﻿using System;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chao Admin","Thong Bao");
            frm_Logout f = new frm_Logout();
            this.Hide();
            f.ShowDialog();
            this.Show();
          
        }

        private void check_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ShowPass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                 txtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
