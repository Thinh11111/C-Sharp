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
    public partial class FastFood_Order : Form
    {
        public FastFood_Order()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FastFood_Order_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Món ăn");
            dt.Columns.Add("Số lượng");

            //dt.Columns.Add("Món ăn", System.Type.GetType("System.String"));
            //dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));

            //dt.Rows.Add(new Object[] { btnPhoMaiTom.Text, 1 });
            //DataRow r = dt.NewRow();
            //r["FootName"] = btnPhoMaiBo.Text;
            //r["Quantity"] = 1;
            //dt.Rows.Add(r);
            
            
            dataGridView1.DataSource = dt;

        }
        public void KT_ThemVaoDGV(string tenMonAn)
        {
            int flag = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //chặn lỗi khi so sánh với dòng cuối cùng của DataGridView
                try
                {
                    //so sanh vứi tên món ăn
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == tenMonAn)
                    {
                        dataGridView1.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + 1;
                        flag = 1;
                        break;
                    }
                }
                catch { }
            }
            if (flag == 0)
            {
                DataTable dt = new DataTable();
                dt = ((DataTable)dataGridView1.DataSource).Copy();
                dataGridView1.DataSource = null;

                DataRow r = dt.NewRow();
                r["Món ăn"] = tenMonAn;
                r["Số lượng"] = 1;
                dt.Rows.Add(r);
                dt.AcceptChanges();
                dataGridView1.DataSource = dt;
            }
            
        }
        private void BtnPhoMaiBo_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnPhoMaiBo.Text);
        }

        private void btnPhoMaiGa_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnPhoMaiGa.Text);
        }
        private void btnPhoMaiTom_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnPhoMaiTom.Text);
        }

        private void btnPhoMaiCa_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnPhoMaiCa.Text);
        }
        private void btnTomVienCola_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnTomVienCola.Text);
        }

        private void btnGaVienCola_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnGaVienCola.Text);
        }

        private void btnGaRanPhan_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnGaRanPhan.Text);
        }

        private void btnComGaTender_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnComGaTender.Text);
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnPepsi.Text);
        }

        private void btn7Up_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btn7Up.Text);
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnCafe.Text);
        }

        private void btnCoca_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnCoca.Text);
        }

        private void btnLipton_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnLipton.Text);
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnCam.Text);
        }

        private void btnKhoaiTayChien_Click(object sender, EventArgs e)
        {
            KT_ThemVaoDGV(btnKhoaiTayChien.Text);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //MessageBox.Show(dataGridView1.Rows[i].Value.ToString());
            }
        }
    }
}
