namespace 第二题
{
    partial class GradeAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.txtGradepeacetime = new System.Windows.Forms.TextBox();
            this.txtGradeexpriment = new System.Windows.Forms.TextBox();
            this.txtGradelast = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "课程号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "平时成绩";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "实验成绩";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "期末成绩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "总成绩";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(202, 31);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 25);
            this.txtSno.TabIndex = 6;
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(202, 77);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(100, 25);
            this.txtCno.TabIndex = 7;
            // 
            // txtGradepeacetime
            // 
            this.txtGradepeacetime.Location = new System.Drawing.Point(202, 125);
            this.txtGradepeacetime.Name = "txtGradepeacetime";
            this.txtGradepeacetime.Size = new System.Drawing.Size(100, 25);
            this.txtGradepeacetime.TabIndex = 8;
            // 
            // txtGradeexpriment
            // 
            this.txtGradeexpriment.Location = new System.Drawing.Point(202, 174);
            this.txtGradeexpriment.Name = "txtGradeexpriment";
            this.txtGradeexpriment.Size = new System.Drawing.Size(100, 25);
            this.txtGradeexpriment.TabIndex = 9;
            // 
            // txtGradelast
            // 
            this.txtGradelast.Location = new System.Drawing.Point(202, 228);
            this.txtGradelast.Name = "txtGradelast";
            this.txtGradelast.Size = new System.Drawing.Size(100, 25);
            this.txtGradelast.TabIndex = 10;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(202, 285);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 25);
            this.txtGrade.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GradeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtGradelast);
            this.Controls.Add(this.txtGradeexpriment);
            this.Controls.Add(this.txtGradepeacetime);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GradeAdd";
            this.Text = "GradeAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.TextBox txtGradepeacetime;
        private System.Windows.Forms.TextBox txtGradeexpriment;
        private System.Windows.Forms.TextBox txtGradelast;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}