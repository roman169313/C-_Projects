namespace quiz_2
{
    partial class frmQuiz_2
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.txtSubjectTitle = new System.Windows.Forms.TextBox();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtSessional = new System.Windows.Forms.TextBox();
            this.txtTheoryMarks = new System.Windows.Forms.TextBox();
            this.txtPracticalMarks = new System.Windows.Forms.TextBox();
            this.txtSubjectTotal = new System.Windows.Forms.TextBox();
            this.txtGp = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.chkPractical = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Title:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Theory Marks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Practical marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "MID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Final:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sessional:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Theory Marks:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Practical marks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Subject Total Marks:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 306);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "G.P:";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(150, 88);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(124, 29);
            this.txtSubjectId.TabIndex = 11;
            // 
            // txtSubjectTitle
            // 
            this.txtSubjectTitle.Location = new System.Drawing.Point(183, 128);
            this.txtSubjectTitle.Name = "txtSubjectTitle";
            this.txtSubjectTitle.Size = new System.Drawing.Size(124, 29);
            this.txtSubjectTitle.TabIndex = 13;
            // 
            // txtMid
            // 
            this.txtMid.Location = new System.Drawing.Point(100, 230);
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(124, 29);
            this.txtMid.TabIndex = 14;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(100, 268);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(124, 29);
            this.txtFinal.TabIndex = 15;
            // 
            // txtSessional
            // 
            this.txtSessional.Location = new System.Drawing.Point(150, 306);
            this.txtSessional.Name = "txtSessional";
            this.txtSessional.Size = new System.Drawing.Size(124, 29);
            this.txtSessional.TabIndex = 16;
            // 
            // txtTheoryMarks
            // 
            this.txtTheoryMarks.Location = new System.Drawing.Point(238, 346);
            this.txtTheoryMarks.Name = "txtTheoryMarks";
            this.txtTheoryMarks.ReadOnly = true;
            this.txtTheoryMarks.Size = new System.Drawing.Size(124, 29);
            this.txtTheoryMarks.TabIndex = 17;
            // 
            // txtPracticalMarks
            // 
            this.txtPracticalMarks.Location = new System.Drawing.Point(524, 230);
            this.txtPracticalMarks.Name = "txtPracticalMarks";
            this.txtPracticalMarks.Size = new System.Drawing.Size(124, 29);
            this.txtPracticalMarks.TabIndex = 18;
            // 
            // txtSubjectTotal
            // 
            this.txtSubjectTotal.Location = new System.Drawing.Point(567, 268);
            this.txtSubjectTotal.Name = "txtSubjectTotal";
            this.txtSubjectTotal.ReadOnly = true;
            this.txtSubjectTotal.Size = new System.Drawing.Size(124, 29);
            this.txtSubjectTotal.TabIndex = 19;
            // 
            // txtGp
            // 
            this.txtGp.Location = new System.Drawing.Point(430, 303);
            this.txtGp.Name = "txtGp";
            this.txtGp.Size = new System.Drawing.Size(124, 29);
            this.txtGp.TabIndex = 20;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(184, 389);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(102, 44);
            this.btnDisplay.TabIndex = 21;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(400, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 44);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(292, 389);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(102, 44);
            this.txtClear.TabIndex = 23;
            this.txtClear.Text = "clear";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // chkPractical
            // 
            this.chkPractical.AutoSize = true;
            this.chkPractical.Location = new System.Drawing.Point(340, 88);
            this.chkPractical.Name = "chkPractical";
            this.chkPractical.Size = new System.Drawing.Size(108, 28);
            this.chkPractical.TabIndex = 24;
            this.chkPractical.Text = "Practical";
            this.chkPractical.UseVisualStyleBackColor = true;
            // 
            // frmQuiz_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 711);
            this.Controls.Add(this.chkPractical);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtGp);
            this.Controls.Add(this.txtSubjectTotal);
            this.Controls.Add(this.txtPracticalMarks);
            this.Controls.Add(this.txtTheoryMarks);
            this.Controls.Add(this.txtSessional);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtMid);
            this.Controls.Add(this.txtSubjectTitle);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmQuiz_2";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.TextBox txtSubjectTitle;
        private System.Windows.Forms.TextBox txtMid;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtSessional;
        private System.Windows.Forms.TextBox txtTheoryMarks;
        private System.Windows.Forms.TextBox txtPracticalMarks;
        private System.Windows.Forms.TextBox txtSubjectTotal;
        private System.Windows.Forms.TextBox txtGp;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.CheckBox chkPractical;
    }
}

