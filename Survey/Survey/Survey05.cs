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
    public partial class Survey05 : MetroForm
    {
        public Survey05()
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
            SurveyEnd surveyEnd = new SurveyEnd();
            surveyEnd.Show();
        }
    }
}
