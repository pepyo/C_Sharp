using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20220515
{
    public partial class Winform1 : Form
    {
        public Winform1()
        {
            InitializeComponent();
            startDateTime = DateTime.Now;
        }
        DateTime startDateTime;
        public DateTime GetStartDateTime()
        {
            return startDateTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }

        private void Winform1_Load(object sender, EventArgs e)
        {

        }
    }
}
