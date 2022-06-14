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
    public partial class Survey01 : MetroForm
    {
        public Survey01()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Survey02 survey02 = new Survey02();
            survey02.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            SurveyC surveyC = new SurveyC();
            surveyC.Show();
        }
    }
}
