namespace 第二题
{
    partial class CourseAdd
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
            this.txtKcid = new System.Windows.Forms.TextBox();
            this.txtKcname = new System.Windows.Forms.TextBox();
            this.txtPeriodexpriment = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtPeriodteaching = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCoursetype = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtKcid
            // 
            this.txtKcid.Location = new System.Drawing.Point(202, 42);
            this.txtKcid.Name = "txtKcid";
            this.txtKcid.Size = new System.Drawing.Size(100, 25);
            this.txtKcid.TabIndex = 0;
            // 
            // txtKcname
            // 
            this.txtKcname.Location = new System.Drawing.Point(202, 93);
            this.txtKcname.Name = "txtKcname";
            this.txtKcname.Size = new System.Drawing.Size(100, 25);
            this.txtKcname.TabIndex = 1;
            // 
            // txtPeriodexpriment
            // 
            this.txtPeriodexpriment.Location = new System.Drawing.Point(202, 145);
            this.txtPeriodexpriment.Name = "txtPeriodexpriment";
            this.txtPeriodexpriment.Size = new System.Drawing.Size(100, 25);
            this.txtPeriodexpriment.TabIndex = 3;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(202, 257);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 25);
            this.txtCredit.TabIndex = 4;
            // 
            // txtPeriodteaching
            // 
            this.txtPeriodteaching.Location = new System.Drawing.Point(202, 201);
            this.txtPeriodteaching.Name = "txtPeriodteaching";
            this.txtPeriodteaching.Size = new System.Drawing.Size(100, 25);
            this.txtPeriodteaching.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "课程编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "课程名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "课程实验学时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "课程讲课学时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "课程学分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "课程类型";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCoursetype
            // 
            this.txtCoursetype.Location = new System.Drawing.Point(202, 317);
            this.txtCoursetype.Name = "txtCoursetype";
            this.txtCoursetype.Size = new System.Drawing.Size(100, 25);
            this.txtCoursetype.TabIndex = 14;
            // 
            // CourseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 446);
            this.Controls.Add(this.txtCoursetype);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeriodteaching);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtPeriodexpriment);
            this.Controls.Add(this.txtKcname);
            this.Controls.Add(this.txtKcid);
            this.Name = "CourseAdd";
            this.Text = "课程添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKcid;
        private System.Windows.Forms.TextBox txtKcname;
        private System.Windows.Forms.TextBox txtPeriodexpriment;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtPeriodteaching;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCoursetype;
    }
}