using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PhucLong
{
    public class LayDuLieu
    {
        public SqlConnection cnn = new SqlConnection();
        public string connectionString = @"Data Source = KAITO\SQLEXPRESS; Initial Catalog = BANHANG; User ID = sa;password = thanhlam123";
        public void KetNoi_SQL()
        {
            cnn = new SqlConnection(connectionString);

            cnn.Open();
        }
        public void DongKetNoi_SQL()
        {
            if (cnn.State==ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public DataTable BangDuLieu = new DataTable();
        //dùng để lấy bảng tạm truyền vào datagridview.
        public DataTable LayBang(string CauLenh)
        {
            try
            {
                KetNoi_SQL();
                SqlDataAdapter Adapter = new SqlDataAdapter(CauLenh, cnn);
                DataSet ds = new DataSet();
                
                Adapter.Fill(BangDuLieu);
            }
            catch
            {
                BangDuLieu = null;
            }
            finally
            {
                DongKetNoi_SQL();
            }

            return BangDuLieu;
        }
        public void ThemDuLieu(string CauLenh)
        {
            KetNoi_SQL();
            //if (cnn == null)
            //    cnn = new SqlConnection(connectionString);
            //if (cnn.State == ConnectionState.Closed)
            //    cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            command = new SqlCommand(CauLenh, cnn);
            adapter.InsertCommand = new SqlCommand(CauLenh, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

        }
    }
}
