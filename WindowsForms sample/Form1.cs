using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms_sample
{
    public partial class frm_memo : Form
    {
        public frm_memo()
        {
            InitializeComponent();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "開く";
            if (dialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = File.ReadAllText(dialog.FileName);

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "テキストファイル(*.txt)|*.txt";
            dialog.Title = "保存";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, textBox1.Text);
            }
        }

        private void 赤ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //テキストボックス内全て色が変わっている！！
            textBox1.ForeColor = Color.Red;
        }

        private void 黒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
    }
    
}

