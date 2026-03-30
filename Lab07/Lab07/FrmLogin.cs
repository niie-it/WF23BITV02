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

namespace Lab07
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //var sql = $"SELECT * FROM NguoiDung WHERE Username = '{TxtUsername.Text}' AND Password = '{TxtPassword.Text}'";
            //var dtNguoiDung = DataProvider.TruyVan_LayDuLieu(sql);
            var sql = "SELECT * FROM NguoiDung WHERE Username = @username AND Password = @password";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@username", TxtUsername.Text),
                new SqlParameter("@password", TxtPassword.Text)
            };
            var dtNguoiDung = DataProvider.SelectData(sql, CommandType.Text, paras);
            if (dtNguoiDung.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
