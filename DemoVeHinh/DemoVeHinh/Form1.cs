using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoVeHinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //vẽ chuỗi
            g.DrawString("Xin chào các bạn", new Font("Arial", 20), Brushes.Red, 100, 50);

            //vẽ HCN rỗng
            g.DrawRectangle(Pens.Blue, 100, 100, 200, 150);

            //vẽ HCN đặc (ruột)
            Brush brush = new SolidBrush(Color.Green);
            g.FillRectangle(brush, 200, 200, 200, 100);
        }
    }
}
