using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            double so01, so02, ketQua;
            if (!double.TryParse(TxtSo01.Text, out so01))
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất");
                TxtSo01.Focus();
                return;
            }
            if (!double.TryParse(TxtSo02.Text, out so02))
            {
                MessageBox.Show("Vui lòng nhập số thứ hai");
                TxtSo02.Focus();
                return;
            }
            if (RadCong.Checked)
            {
                ketQua = so01 + so02;
                TxtKetQua.Text = ketQua.ToString();
            }
            else if (RadTru.Checked)
            {
                ketQua = so01 - so02;
                TxtKetQua.Text = ketQua.ToString();
            }
            else if (RadNhan.Checked)
            {
                ketQua = so01 * so02;
                TxtKetQua.Text = ketQua.ToString();
            }
            else if (RadChia.Checked)
            {
                if (so02 == 0)
                {
                    MessageBox.Show("Không thể chia cho 0");
                    TxtKetQua.Clear();
                    TxtSo02.Focus();
                    return;
                }
                ketQua = so01 / so02;
                TxtKetQua.Text = ketQua.ToString();
            }
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            TxtSo01.Clear(); TxtSo02.Clear(); TxtKetQua.Clear();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            var traLoi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
            {
                Application.Exit();//đóng ứng dụng
                //this.Close();//đóng form hiện tại
            }
        }
    }
}
