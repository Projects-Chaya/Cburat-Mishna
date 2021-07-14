namespace WinFormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFillTable = new System.Windows.Forms.Button();
            this.tblPrint = new System.Windows.Forms.TableLayoutPanel();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbContinue = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFillTable
            // 
            this.btnFillTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFillTable.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillTable.Location = new System.Drawing.Point(816, 117);
            this.btnFillTable.Name = "btnFillTable";
            this.btnFillTable.Size = new System.Drawing.Size(75, 23);
            this.btnFillTable.TabIndex = 0;
            this.btnFillTable.Text = "התחלה";
            this.btnFillTable.UseVisualStyleBackColor = true;
            this.btnFillTable.Click += new System.EventHandler(this.btnFillTables);
            // 
            // tblPrint
            // 
            this.tblPrint.BackColor = System.Drawing.Color.Transparent;
            this.tblPrint.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblPrint.ColumnCount = 7;
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.tblPrint.Font = new System.Drawing.Font("Franklin Gothic Book", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPrint.Location = new System.Drawing.Point(139, 54);
            this.tblPrint.Name = "tblPrint";
            this.tblPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tblPrint.RowCount = 8;
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrint.Size = new System.Drawing.Size(550, 600);
            this.tblPrint.TabIndex = 2;
            // 
            // cmbName
            // 
            this.cmbName.Font = new System.Drawing.Font("Gisha", 8.25F);
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(797, 88);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(94, 21);
            this.cmbName.TabIndex = 3;
            // 
            // btnContinue
            // 
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(816, 147);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "דף הבא";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinued);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(794, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "בחירת שם משתמש";
            // 
            // lbContinue
            // 
            this.lbContinue.AutoSize = true;
            this.lbContinue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbContinue.Font = new System.Drawing.Font("Gisha", 8.25F);
            this.lbContinue.Location = new System.Drawing.Point(785, 151);
            this.lbContinue.Name = "lbContinue";
            this.lbContinue.Size = new System.Drawing.Size(15, 15);
            this.lbContinue.TabIndex = 7;
            this.lbContinue.Text = "1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrinter
            // 
            this.btnPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrinter.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrinter.Location = new System.Drawing.Point(816, 178);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(75, 23);
            this.btnPrinter.TabIndex = 9;
            this.btnPrinter.Text = "שמירה";
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrint);
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbDate.Location = new System.Drawing.Point(770, 235);
            this.rbDate.Name = "rbDate";
            this.rbDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbDate.Size = new System.Drawing.Size(121, 18);
            this.rbDate.TabIndex = 10;
            this.rbDate.Text = "הדפסה לפי תאריך";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbNumber.Location = new System.Drawing.Point(775, 209);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbNumber.Size = new System.Drawing.Size(116, 18);
            this.rbNumber.TabIndex = 11;
            this.rbNumber.Text = "הדפסה לפי מספר";
            this.rbNumber.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gisha", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(317, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "חבורת משנה  ";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(12, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseForm);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Gisha", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(12, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "חזרה";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnPrintTable);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(909, 693);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbNumber);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.lbContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.tblPrint);
            this.Controls.Add(this.btnFillTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillTable;
        private System.Windows.Forms.TableLayoutPanel tblPrint;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbContinue;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
    }
}

