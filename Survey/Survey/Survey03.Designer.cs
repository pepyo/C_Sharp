namespace Survey
{
    partial class Survey03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Location = new System.Drawing.Point(200, 96);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(400, 30);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "디자이너";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.Location = new System.Drawing.Point(200, 132);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(400, 30);
            this.metroCheckBox2.TabIndex = 0;
            this.metroCheckBox2.Text = "기획자";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.Location = new System.Drawing.Point(200, 168);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(400, 30);
            this.metroCheckBox3.TabIndex = 0;
            this.metroCheckBox3.Text = "프로그래머";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.Location = new System.Drawing.Point(200, 204);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(400, 30);
            this.metroCheckBox4.TabIndex = 0;
            this.metroCheckBox4.Text = "엔지니어";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.Location = new System.Drawing.Point(200, 240);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(400, 30);
            this.metroCheckBox5.TabIndex = 0;
            this.metroCheckBox5.Text = "정보 보안 전문가";
            this.metroCheckBox5.UseSelectable = true;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.Location = new System.Drawing.Point(200, 276);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(400, 30);
            this.metroCheckBox6.TabIndex = 0;
            this.metroCheckBox6.Text = "기타";
            this.metroCheckBox6.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(727, 387);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(50, 40);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "다음";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(671, 387);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(50, 40);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "이전";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Survey03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroCheckBox6);
            this.Controls.Add(this.metroCheckBox5);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Name = "Survey03";
            this.Text = "Q2. 희망하는 분야는 무엇입니까?";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}