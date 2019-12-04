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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable("People");

            //dt.Columns.Add("First Name",
            //System.Type.GetType("System.String"));
            //dt.Columns.Add("Last Name",
            //System.Type.GetType("System.String"));
            //dt.Columns.Add("Occupation",
            //System.Type.GetType("System.String"));
            //dt.Columns.Add("Salary",
            //System.Type.GetType("System.Int32"));

            //dt.Rows.Add(new Object[] { "Rod", "Stephens", "Nerd", 10000 });
            //dt.Rows.Add(new Object[] { "Sergio ", "Aragones", "Cartoonist", 20000 });
            //dt.Rows.Add(new Object[] { "Eoin", "Colfer", "Author", 30000 });
            //dt.Rows.Add(new Object[] { "Terry", "Pratchett", "Author", 40000 });

            //dataGridView1.DataSource = dt;

            //List View
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Tên Sản Phẩm", 100);
            listView1.Columns.Add("Giá", 70);
            listView1.Columns.Add("Số Lượng", 70);

            string[] arr = new string[4];
            ListViewItem itm;

            arr[0] = "Sản Phẩm 01";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            arr[0] = "Sản Phẩm 02";
            arr[1] = "200";
            arr[2] = "20";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);



        }

        private void BtnSelect2_Click(object sender, EventArgs e)
        {
            string productName = null;
            string price = null;
            string quantily = null;

            if (listView1.SelectedItems.Count > 0)
            {
                productName = listView1.SelectedItems[0].SubItems[0].Text;
                price = listView1.SelectedItems[0].SubItems[1].Text;
                quantily = listView1.SelectedItems[0].SubItems[2].Text;
                MessageBox.Show(productName + " , " + price + " , " + quantily + " , ");
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm");
            }
        }
    }
}
