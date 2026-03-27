using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMDI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int childFormNumber = 0;
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmChild = new FrmChild();
            frmChild.MdiParent = this;
            childFormNumber++;
            frmChild.Text = "Window " + childFormNumber;
            frmChild.Show();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //đóng form hiện tại (nếu có)
            if (ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void closeAllFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
        }
    }
}
