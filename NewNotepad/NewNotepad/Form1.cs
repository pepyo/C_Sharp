using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = "";

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            String data = System.IO.File.ReadAllText(filename);
            textBox1.Text = data;
        }   

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();
                
                System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                filename = saveFileDialog1.FileName;
            }
            else
            {
                    
                System.IO.File.WriteAllText(filename, textBox1.Text);
            }
        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            this.saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName,textBox1.Text);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = !textBox1.WordWrap;
        }

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (상태표시줄ToolStripMenuItem.Checked == true)
            {
                statusStrip1.Visible = true;
            }
            else
            {
                statusStrip1.Visible = false;
            }
        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}


