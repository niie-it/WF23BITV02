using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoDong.Text, out int soDong) || soDong < 1)
            {
                MessageBox.Show("Số dòng không hợp lệ!");
                txtSoDong.Focus();
                return;
            }
            if (!int.TryParse(txtSoCot.Text, out int soCot) || soCot < 1)
            {
                MessageBox.Show("Số cột không hợp lệ!");
                txtSoCot.Focus();
                return;
            }
            var f = new FrmBang();
            f.SoCot = soCot;
            f.SoDong = soDong;
            f.Text = "Bảng";
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
l
        }
    }
}
