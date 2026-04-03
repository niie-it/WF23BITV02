using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08QLHS
{
    public partial class Form1 : Form
    {
        QLHSDataContext db = new QLHSDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lấy ds lớp đổ vào comboBox Lớp
            layDsLop();
            //ép chọn lớp đầu tiên
            CboLop.SelectedIndex = 0;
            layHocSinhTheoLop();
        }

        private void layHocSinhTheoLop()
        {
            var dsHocSinh = db.HocSinhs
                .Where(hs => hs.MaLop == CboLop.SelectedValue.ToString());
            dgvHocSinh.DataSource = null;
            dgvHocSinh.DataSource = dsHocSinh;
        }
        private void CboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            layHocSinhTheoLop();
        }

        private void layDsLop()
        {
            CboLop.DataSource = db.Lops.ToList();
            CboLop.DisplayMember = "TenLop";
            CboLop.ValueMember = "MaLop";
        }


    }
}
