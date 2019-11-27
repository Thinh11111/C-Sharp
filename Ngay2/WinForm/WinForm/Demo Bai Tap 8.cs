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
    public partial class Demo_Bai_Tap_8 : Form
    {
        public Demo_Bai_Tap_8()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //---------Khai báo một INFO để lưu thông tin của người nhập
            //---------string info= "Name: " + tbxName.Text.ToString() + "\nAddress: " + tbxAddress.Text.ToString() + "\nCiTy: ";
            string info="";
            //---------Kiểm tra các điều kiện nếu không nhập hoặc chưa check đầy đủ thì báo cho người dùng biết
            if (tbxName.Text.ToString() == "")
            {
                MessageBox.Show("Chưa điền tên","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tbxAddress.Text == "")
            {
                MessageBox.Show("Chưa điền địa chỉ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //Kiểm tra listbox
            else if (lstCity.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn thành phố", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //---------check phần radio box
            else if (rbtMale.Checked == false && rbtFemale.Checked == false && rbtLBGT.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thiếu Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //-----------check phần checkbox
            else if (cbxC.Checked == false && cbxJava.Checked == false && cbxPython.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn ngôn ngữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                info = info + "Name: " + tbxName.Text.ToString() + "\nAddress: " + tbxAddress.Text.ToString();
                info = info + "\nCity: " + lstCity.SelectedItem;
                if (rbtMale.Checked == true)
                {
                    info = info + "\nGender: Male";
                }
                else if (rbtFemale.Checked == true)
                {
                    info = info + "\nGender: Female";
                }
                else if (rbtLBGT.Checked == true)
                {
                    info = info + "\nGender: LGBT";
                }
                //------------
                info = info + "\nCourse:";
                if (cbxC.Checked == true)
                {
                    info = info + " C#";
                }
                if (cbxJava.Checked == true)
                {
                    info = info + " Java";
                }
                if (cbxPython.Checked == true)
                {
                    info = info + " Python";
                }
                //---------Hiển thị thông tin
                MessageBox.Show(info, "Thông Tin Vừa Nhập");
            }
            /*
            //----------Kiểm tra nếu check phần nào thì thêm phần đó vào info
            if (tbxName.Text != "" && tbxAddress.Text != "")
            {
                info = info + "Name: " + tbxName.Text.ToString() + "\nAddress: " + tbxAddress.Text.ToString();
            }
            if (lstCity.SelectedIndex != -1)
            {
                info = info + "\nCity: "+lstCity.SelectedItem;
            }
            if (rbtMale.Checked == true)
            {
                info = info + "\nGender: Male";
            }
            else if (rbtFemale.Checked == true)
            {
                info = info + "\nGender: Female";
            }
            else if (rbtLBGT.Checked == true)
            {
                info = info + "\nGender: LGBT";
            }
            //------------
            info = info + "\nCourse:";
            if (cbxC.Checked == true)
            {
                info = info + " C#";
            }
            if (cbxJava.Checked == true)
            {
                info = info + " Java";
            }
            if (cbxPython.Checked == true)
            {
                info = info + " Python";
            }*/
            
        }

        private void RbtMale_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void LbxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
