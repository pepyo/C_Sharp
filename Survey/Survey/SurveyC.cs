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
using System.Data.SqlClient;

namespace Survey
{
    public partial class SurveyC : MetroForm
    {
        public SurveyC()
        {
            InitializeComponent();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PYO\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM USERINFO WHERE USERNAME='" + metroTextBox1.Text + "' AND PASSWORD='" + metroTextBox2.Text + "'", con);

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if (newTable.Rows[0][0].ToString() == "1")
            {
                CMODE cmode = new CMODE();
                cmode.Show();
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호를 확인하시오");
            }
        }


    }
}
