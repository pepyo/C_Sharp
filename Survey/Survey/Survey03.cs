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
    public partial class Survey03 : MetroForm
    {
        public Survey03()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Survey02 survey02 = new Survey02();
            survey02.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Survey04 survey04 = new Survey04();
            survey04.Show();
        }
    }
}
