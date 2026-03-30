using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuMoFormQLLop(object sender, EventArgs e)
        {
            var form = new FrmQLLop();
            form.MdiParent = this;
            form.Show();
            lblStatus.Text = "Đã mở form quản lý lớp học.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
