namespace 第二题
{
    partial class ClassAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassid = new System.Windows.Forms.TextBox();
            this.txtSpecialtyid = new System.Windows.Forms.TextBox();
            this.txtStudentnumber = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "班级号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "专业代码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "班级人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "备注";
            // 
            // txtClassid
            // 
            this.txtClassid.Location = new System.Drawing.Point(134, 20);
            this.txtClassid.Name = "txtClassid";
            this.txtClassid.Size = new System.Drawing.Size(100, 25);
            this.txtClassid.TabIndex = 6;
            // 
            // txtSpecialtyid
            // 
            this.txtSpecialtyid.Location = new System.Drawing.Point(134, 62);
            this.txtSpecialtyid.Name = "txtSpecialtyid";
            this.txtSpecialtyid.Size = new System.Drawing.Size(100, 25);
            this.txtSpecialtyid.TabIndex = 7;
            // 
            // txtStudentnumber
            // 
            this.txtStudentnumber.Location = new System.Drawing.Point(134, 104);
            this.txtStudentnumber.Name = "txtStudentnumber";
            this.txtStudentnumber.Size = new System.Drawing.Size(100, 25);
            this.txtStudentnumber.TabIndex = 8;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(134, 154);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(100, 25);
            this.txtRemark.TabIndex = 9;
            // 
            // ClassAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 279);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtStudentnumber);
            this.Controls.Add(this.txtSpecialtyid);
            this.Controls.Add(this.txtClassid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ClassAdd";
            this.Text = "ClassAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClassid;
        private System.Windows.Forms.TextBox txtSpecialtyid;
        private System.Windows.Forms.TextBox txtStudentnumber;
        private System.Windows.Forms.TextBox txtRemark;
    }
}