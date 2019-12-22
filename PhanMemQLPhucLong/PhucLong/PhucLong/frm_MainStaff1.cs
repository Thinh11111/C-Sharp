using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PhucLong
{
    public partial class frm_MainStaff1 : Form
    {
        public frm_MainStaff1()
        {
            InitializeComponent();
        }
        //public LayDuLieu kn = new LayDuLieu();
        public void LoadGrid(DataGridView datagird, string cauLenh)
        {
            LayDuLieu kn = new LayDuLieu();
            datagird.DataSource = kn.LayBang("select * from " + cauLenh + "");
        }
        private void frm_MainStaff1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGDataSet2.KH' table. You can move, or remove it, as needed.
            this.kHTableAdapter.Fill(this.bANHANGDataSet2.KH);
            // TODO: This line of code loads data into the 'bANHANGDataSet11.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.bANHANGDataSet11.HOADON);
            // TODO: This line of code loads data into the 'bANHANGDataSet.NGK' table. You can move, or remove it, as needed.
            this.nGKTableAdapter.Fill(this.bANHANGDataSet.NGK);
            LoadGrid(dataGridView1, "NGK");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtMa.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            txtQuyCach.Text = row.Cells[2].Value.ToString();
            txtMaLoai.Text = row.Cells[3].Value.ToString();
        }
        private void btnTimTheoTen_Click_1(object sender, EventArgs e)
        {
            LayDuLieu kn = new LayDuLieu();
            dataGridView1.DataSource = kn.LayBang("select * from NGK where TenNGK like N'%" + txtTuTim.Text + "%'");
        }

        private void btnHienTatCa_Click_1(object sender, EventArgs e)
        {
            LoadGrid(dataGridView1, "NGK");
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            pnlBanHang.Visible = true;
            pnlHoaDon.Visible = false;
            pnlChiTietHoaDon.Visible = false;
            pnlSanPham.Visible = false;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            pnlBanHang.Visible = false;
            pnlChiTietHoaDon.Visible = false;
            pnlSanPham.Visible = false;
            pnlHoaDon.Visible = true;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            pnlBanHang.Visible = false;
            pnlChiTietHoaDon.Visible = false;
            pnlHoaDon.Visible = false;
            pnlSanPham.Visible = true;
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            pnlBanHang.Visible = false;
            pnlHoaDon.Visible = false;
            pnlSanPham.Visible = false;
            pnlChiTietHoaDon.Visible = true;
        }

        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            LayDuLieu kn = new LayDuLieu();
            dataGridView1.DataSource = kn.LayBang("select * from NGK where TenNGK like N'%" + txtTuTim.Text + "%'");
        }

        private void btnDangXuat_MouseHover(object sender, EventArgs e)
        {
            btnDangXuat.ForeColor = Color.Red;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //test kiem tra ma hoa don da co
            //int flag = 0;
            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    if (String.Compare(dataGridView1.Rows[i].Cells[0].Value.ToString(), txtMaHD.Text, true) == 0)
            //    {
            //        MessageBox.Show("Mã hóa đơn đã có");
            //        flag = 1;
            //        break;
            //    }
            //}

            //if (flag == 1)
            //{
            //    string lenhsql = "Insert into HoaDon(SoHD,NgaylapHD,MaKH) values('" + txtMaHD.Text + "' ,'" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "','" + cbbMaKH.Text + "')";
            //    LayDuLieu kn = new LayDuLieu();
            //    kn.ThemDuLieu(lenhsql);

            //    LoadGrid(dgvHoaDon, "HoaDon");
            //}

            string lenhsql = "Insert into HoaDon(SoHD,NgaylapHD,MaKH) values('" + txtMaHD.Text + "' ,'" + dtpNgayLap.Value.ToString("yyyy/MM/dd") + "','" + cbbMaKH.Text + "')";
            LayDuLieu kn = new LayDuLieu();
            kn.ThemDuLieu(lenhsql);

            LoadGrid(dgvHoaDon, "HoaDon");

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn Thanh Toán không?", "Thanh Toán", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công");
            }
            else
            {
                
            }
        }
    }
}
