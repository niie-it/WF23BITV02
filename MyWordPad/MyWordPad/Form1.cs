using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWordPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName = string.Empty;
        bool isChange = false;

        private void XuLySave(object sender, EventArgs e)
        {
            if (fileName == string.Empty)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text Format|*.rtf|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    saveFile(fileName);
                }
            }
            else
            {
                saveFile(fileName);
            }
        }

        private void saveFile(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLower();
            if (extension == ".rtf")
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                File.WriteAllText(fileName, richTextBox1.Text);
            }
        }

        private void XuLyOpen(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|Rich Text Format|*.rtf|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var extension = Path.GetExtension(ofd.FileName).ToLower();
                if (extension == ".rtf")
                {
                    richTextBox1.LoadFile(ofd.FileName);
                }
                else
                {
                    richTextBox1.Text = File.ReadAllText(ofd.FileName);
                }
            }
        }

        private void MenuSelectFont_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.Apply += new EventHandler(XuLyApplyFont);
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
                richTextBox1.SelectionColor = fontDialog.Color;
            }
        }

        private void XuLyApplyFont(object sender, EventArgs e)
        {
            var fontDialog = sender as FontDialog;
            richTextBox1.SelectionFont = fontDialog.Font;
            richTextBox1.SelectionColor = fontDialog.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
