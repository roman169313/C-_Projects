namespace ListingAding
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
            this.lba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAdd = new System.Windows.Forms.ListBox();
            this.lstMatch = new System.Windows.Forms.ListBox();
            this.lstUnmatch = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(273, 99);
            this.lba.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(210, 24);
            this.lba.TabIndex = 1;
            this.lba.Text = "list of Matched Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "list of add words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unmatched words";
            // 
            // lstAdd
            // 
            this.lstAdd.FormattingEnabled = true;
            this.lstAdd.ItemHeight = 24;
            this.lstAdd.Location = new System.Drawing.Point(65, 133);
            this.lstAdd.Name = "lstAdd";
            this.lstAdd.Size = new System.Drawing.Size(155, 244);
            this.lstAdd.TabIndex = 4;
            // 
            // lstMatch
            // 
            this.lstMatch.FormattingEnabled = true;
            this.lstMatch.ItemHeight = 24;
            this.lstMatch.Location = new System.Drawing.Point(277, 133);
            this.lstMatch.Name = "lstMatch";
            this.lstMatch.Size = new System.Drawing.Size(155, 244);
            this.lstMatch.TabIndex = 5;
            // 
            // lstUnmatch
            // 
            this.lstUnmatch.FormattingEnabled = true;
            this.lstUnmatch.ItemHeight = 24;
            this.lstUnmatch.Location = new System.Drawing.Point(500, 133);
            this.lstUnmatch.Name = "lstUnmatch";
            this.lstUnmatch.Size = new System.Drawing.Size(155, 244);
            this.lstUnmatch.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(500, 450);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(122, 39);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "Add to List of Words";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(277, 450);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(122, 39);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(64, 415);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 29);
            this.txtAdd.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstUnmatch);
            this.Controls.Add(this.lstMatch);
            this.Controls.Add(this.lstAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lba);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstAdd;
        private System.Windows.Forms.ListBox lstMatch;
        private System.Windows.Forms.ListBox lstUnmatch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtAdd;
    }
}

