namespace 第二题
{
    partial class TeacherAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTeaid = new System.Windows.Forms.TextBox();
            this.txtTeaname = new System.Windows.Forms.TextBox();
            this.txtTeasex = new System.Windows.Forms.TextBox();
            this.txtTeloffice = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTeabirthday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师代码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "教师姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "教师性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "办公电话";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "家庭住址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "出生日期";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTeaid
            // 
            this.txtTeaid.Location = new System.Drawing.Point(219, 33);
            this.txtTeaid.Name = "txtTeaid";
            this.txtTeaid.Size = new System.Drawing.Size(100, 25);
            this.txtTeaid.TabIndex = 7;
            // 
            // txtTeaname
            // 
            this.txtTeaname.Location = new System.Drawing.Point(219, 90);
            this.txtTeaname.Name = "txtTeaname";
            this.txtTeaname.Size = new System.Drawing.Size(100, 25);
            this.txtTeaname.TabIndex = 8;
            // 
            // txtTeasex
            // 
            this.txtTeasex.Location = new System.Drawing.Point(219, 152);
            this.txtTeasex.Name = "txtTeasex";
            this.txtTeasex.Size = new System.Drawing.Size(100, 25);
            this.txtTeasex.TabIndex = 9;
            // 
            // txtTeloffice
            // 
            this.txtTeloffice.Location = new System.Drawing.Point(219, 218);
            this.txtTeloffice.Name = "txtTeloffice";
            this.txtTeloffice.Size = new System.Drawing.Size(100, 25);
            this.txtTeloffice.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(219, 282);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 25);
            this.txtAddress.TabIndex = 11;
            // 
            // txtTeabirthday
            // 
            this.txtTeabirthday.Location = new System.Drawing.Point(219, 348);
            this.txtTeabirthday.Name = "txtTeabirthday";
            this.txtTeabirthday.Size = new System.Drawing.Size(100, 25);
            this.txtTeabirthday.TabIndex = 12;
            // 
            // TeacherAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 466);
            this.Controls.Add(this.txtTeabirthday);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtTeloffice);
            this.Controls.Add(this.txtTeasex);
            this.Controls.Add(this.txtTeaname);
            this.Controls.Add(this.txtTeaid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherAdd";
            this.Text = "TeacherAdd";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTeaid;
        private System.Windows.Forms.TextBox txtTeaname;
        private System.Windows.Forms.TextBox txtTeasex;
        private System.Windows.Forms.TextBox txtTeloffice;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTeabirthday;
    }
}