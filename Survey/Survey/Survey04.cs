using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Survey
{
    public partial class Survey04 : MetroForm
    {
        public Survey04()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Survey03 survey03 = new Survey03();
            survey03.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Survey05 survey05 = new Survey05();
            survey05.Show();
        }
    }
}
