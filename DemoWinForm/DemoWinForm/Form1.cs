using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWinForm
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

        private void btnChao_Click(object sender, EventArgs e)
        {
            var chuoi = $"Xin chào {txtHoTen.Text}";
            txtKetQua.Text = chuoi;
        }

        private void txtHoTen_KeyUp(object sender, KeyEventArgs e)
        {
            lblThongBao.Text = txtHoTen.Text;
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
