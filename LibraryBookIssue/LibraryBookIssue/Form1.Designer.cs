namespace LibraryBookIssue
{
    partial class Form1
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
            this.txtBookIssueId = new System.Windows.Forms.TextBox();
            this.cbRollNo = new System.Windows.Forms.ComboBox();
            this.cbBookId = new System.Windows.Forms.ComboBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBookIssue = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Issue Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Roll No:";
            // 
            // txtBookIssueId
            // 
            this.txtBookIssueId.Location = new System.Drawing.Point(228, 57);
            this.txtBookIssueId.Name = "txtBookIssueId";
            this.txtBookIssueId.Size = new System.Drawing.Size(170, 29);
            this.txtBookIssueId.TabIndex = 5;
            // 
            // cbRollNo
            // 
            this.cbRollNo.FormattingEnabled = true;
            this.cbRollNo.Location = new System.Drawing.Point(228, 99);
            this.cbRollNo.Name = "cbRollNo";
            this.cbRollNo.Size = new System.Drawing.Size(170, 32);
            this.cbRollNo.TabIndex = 6;
            this.cbRollNo.SelectedIndexChanged += new System.EventHandler(this.cbRollNo_SelectedIndexChanged);
            // 
            // cbBookId
            // 
            this.cbBookId.FormattingEnabled = true;
            this.cbBookId.Location = new System.Drawing.Point(228, 144);
            this.cbBookId.Name = "cbBookId";
            this.cbBookId.Size = new System.Drawing.Size(170, 32);
            this.cbBookId.TabIndex = 7;
            this.cbBookId.SelectedIndexChanged += new System.EventHandler(this.cbBookId_SelectedIndexChanged);
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(228, 192);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(170, 29);
            this.dtpIssueDate.TabIndex = 8;
            this.dtpIssueDate.Value = new System.DateTime(2023, 4, 26, 20, 56, 34, 0);
            // 
            // dgvBookIssue
            // 
            this.dgvBookIssue.AllowUserToAddRows = false;
            this.dgvBookIssue.AllowUserToDeleteRows = false;
            this.dgvBookIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookIssue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBookIssue.Location = new System.Drawing.Point(0, 314);
            this.dgvBookIssue.Name = "dgvBookIssue";
            this.dgvBookIssue.ReadOnly = true;
            this.dgvBookIssue.Size = new System.Drawing.Size(537, 150);
            this.dgvBookIssue.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(334, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 464);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBookIssue);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.cbBookId);
            this.Controls.Add(this.cbRollNo);
            this.Controls.Add(this.txtBookIssueId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookIssueId;
        private System.Windows.Forms.ComboBox cbRollNo;
        private System.Windows.Forms.ComboBox cbBookId;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DataGridView dgvBookIssue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}

