namespace WinFormPrint
{
    partial class TableForm
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labPage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(343, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "חבורת משנה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(200, 697);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "חבורת ש\"ס ת.ד 50135 טל: 02-5871819 או 054-5312238\r\nP.O HOX 380 LAKEWOOD NJ 08701 " +
    "PH 732-730-9496 בארה\"ב  \r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(650, 29);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 20);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "הדפסה";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrinter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(747, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "בס\"ד";
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Font = new System.Drawing.Font("Gisha", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbPage.Location = new System.Drawing.Point(3, 675);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(0, 13);
            this.lbPage.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Gisha", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbName.Location = new System.Drawing.Point(488, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 15);
            this.lbName.TabIndex = 4;
            this.lbName.UseMnemonic = false;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labName.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labName.Location = new System.Drawing.Point(40, 35);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(2, 16);
            this.labName.TabIndex = 9;
            // 
            // labPage
            // 
            this.labPage.AutoSize = true;
            this.labPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labPage.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labPage.Location = new System.Drawing.Point(40, 9);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(2, 16);
            this.labPage.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.Location = new System.Drawing.Point(724, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 20);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "סגור";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseForm);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 725);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labPage);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPage;
        private System.Windows.Forms.Button btnClose;
    }
}