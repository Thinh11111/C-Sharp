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

namespace WinformKetSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = KAITO\SQLEXPRESS; Initial Catalog = demotb; Integrated Security = True; User ID=sa; Password=thanhlam123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //MessageBox.Show("Connection Open!");
            //Truy cap csdl
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            sql = "select TutorialID,TutorialName from Tutorial";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            cnn.Close();


        }

        private void btnIsert_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = KAITO\SQLEXPRESS; Initial Catalog = demotb; Integrated Security = True; User ID=sa; Password=thanhlam123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //Insert 
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            
            sql = "Insert into Tutorial(TutorialID,TutorialName) values('"+txtID.Text+"' ,'"+txtName.Text+"')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = KAITO\SQLEXPRESS; Initial Catalog = demotb; Integrated Security = True; User ID=sa; Password=thanhlam123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //Insert 
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            
            sql = "delete Tutorial where TutorialID="+txtChonXoa.Text+" ";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source = KAITO\SQLEXPRESS; Initial Catalog = demotb; Integrated Security = True; User ID=sa; Password=thanhlam123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //Insert 
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "update Tutorial set TutorialName='"+txtName.Text + "' where TutorialID='"+txtID.Text+"' ";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demotbDataSet.Tutorial' table. You can move, or remove it, as needed.
            this.tutorialTableAdapter.Fill(this.demotbDataSet.Tutorial);

        }
    }
}
