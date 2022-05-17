using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "파일 오픈창";
            ofd.FileName = "";
            ofd.Filter = "텍스트 파일 (*.txt) | *.txt";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileNamel = ofd.SafeFileName.Substring(0, ofd.SafeFileName.Length - 4);
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8);
                int position = ofd.FileName.LastIndexOf("\\");
                string textFileName = ofd.FileName.Substring(position + 1);
                this.Text = textFileName + " Notepad";
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e){
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일 (*.txt) | *.txt";
            if (sfd.ShowDialog() == DialogResult.OK){
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e){
                textBox1.Text = string.Empty;
            }
    }
}