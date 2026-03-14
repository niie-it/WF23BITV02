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
    public partial class FrmBang : Form
    {
        public int SoDong { get; set; }
        public int SoCot { get; set; }

        public FrmBang()
        {
            InitializeComponent();
        }

        const int ButtonSize = 60;
        const int Spacing = 20;
        private void FrmBang_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    var btn = new Button();
                    btn.Text = $"({i},{j})";
                    btn.Width = ButtonSize;
                    btn.Height = ButtonSize;
                    btn.Left = Spacing + j * (ButtonSize + Spacing);
                    btn.Top = Spacing + i * (ButtonSize + Spacing);
                    btn.Click += XuLyClick;
                    btn.MouseHover += new EventHandler(XuLyHover);
                    this.Controls.Add(btn);
                }
            }

            this.Width = Spacing + SoCot * (ButtonSize + Spacing) + 20;
            this.Height = Spacing + SoDong * (ButtonSize + Spacing) + 40;
        }

        private void XuLyHover(object sender, EventArgs e)
        {
            this.Text = $"Bạn đang hover vào nút {(sender as Button).Text}";
        }

        private void XuLyClick(object sender, EventArgs e)
        {
            //if (sender is Button btn)
            Button btn = sender as Button;
            MessageBox.Show($"Bạn đã click vào nút {btn.Text}");
        }
    }
}
