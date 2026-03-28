using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoQLHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            layDanhSachLop();
        }

        string chuoiKetNoi = @"Data Source=.;Initial Catalog=QuanLyHocSinh;Integrated Security=True;";

        private void layDanhSachLop()
        {
            var conn = new SqlConnection(chuoiKetNoi);
            conn.Open();
            var dataTable = new DataTable();
            var dataAdapter = new SqlDataAdapter("SELECT * FROM Lop", conn);
            dataAdapter.Fill(dataTable);
            conn.Close();

            dataGridView1.DataSource = dataTable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var sql = $"INSERT INTO Lop (MaLop, TenLop, SiSo) VALUES ('{txtMaLop.Text}', N'{txtTenLop.Text}', '{txtSiSo.Text}')";
            //MessageBox.Show(sql);
            
            var conn = new SqlConnection(chuoiKetNoi);
            var cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}
