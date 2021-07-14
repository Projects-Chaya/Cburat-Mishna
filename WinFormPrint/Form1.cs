using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Globalization;

namespace WinFormPrint
{
    public partial class Form1 : Form
    {
        int rowNumber = 8;
        int number = -1;
        int numberloop=0;
        int continues = 1;
        int countFile;
        bool clicked=false;
        string kod;
        int k = 0;
        int count;
        int numbers = 1;
        int countLine;
        string nameUser;

        //public const int SRCCOPY = 0x00CC0020;
        //[DllImport("gdi32.dll")]
        //public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
        //    int nWidth, int nHeight, IntPtr hObjectSource,
        //    int nXSrc, int nYSrc, int dwRop);

        //[DllImport("gdi32.dll")]
        //public static extern bool StretchBlt(
        //      IntPtr hdcDest,      // handle to destination DC
        //      int nXOriginDest, // x-coord of destination upper-left corner
        //      int nYOriginDest, // y-coord of destination upper-left corner
        //      int nWidthDest,   // width of destination rectangle
        //      int nHeightDest,  // height of destination rectangle
        //      IntPtr hdcSrc,       // handle to source DC
        //      int nXOriginSrc,  // x-coord of source upper-left corner
        //      int nYOriginSrc,  // y-coord of source upper-left corner
        //      int nWidthSrc,    // width of source rectangle
        //      int nHeightSrc,   // height of source rectangle
        //      int dwRop       // raster operation code
        //    );


        //[DllImport("gdi32.dll")]
        //public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
        //    int nHeight);
        //[DllImport("gdi32.dll")]
        //public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
        //[DllImport("gdi32.dll")]
        //public static extern bool DeleteDC(IntPtr hDC);
        //[DllImport("gdi32.dll")]
        //public static extern bool DeleteObject(IntPtr hObject);
        //[DllImport("gdi32.dll")]
        //public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);


        //[StructLayout(LayoutKind.Sequential)]
        //public struct RECT
        //{
        //    public int left;
        //    public int top;
        //    public int right;
        //    public int bottom;
        //}

        //[DllImport("user32.dll")]
        //public static extern IntPtr GetDesktopWindow();
        //[DllImport("user32.dll")]
        //public static extern IntPtr GetWindowDC(IntPtr hWnd);
        //[DllImport("user32.dll")]
        //public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
        //[DllImport("user32.dll")]
        //public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

        public void createCmb()
        {
            DataTable table = new DataTable();
            BlPrint.BlBase bl = new BlPrint.BlBase();
            table = bl.GetCmb();
            cmbName.DataSource = table;
            cmbName.DisplayMember = "User_Name";
            cmbName.ValueMember = "Kodz";
            
        }
        public Form1()
        {
            InitializeComponent();
            createCmb();
            //btnPrinter.Click +=new EventHandler(btnPrint);
            //printDocument1.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);
        }
        private void btnFillTables(object sender, EventArgs e)
        {
            clicked = true;
            kod = cmbName.SelectedValue.ToString();
            //(string)comboBox1.Items[e.Index]
            nameUser = cmbName.Text;
            //MessageBox.Show(kod.ToString());
            countFile = maxFiles(kod);
            if (rbDate.Checked == false && rbNumber.Checked == false)
                MessageBox.Show("לא נבחר סוג הדפסה");
            else 
                FillTables(kod);
        }
        int i;
        private void FillTables(string kod)
        {
            tblPrint.Hide();
            tblPrint.Controls.Clear();
            DataTable table = new DataTable();   
            BlPrint.BlBase bl = new BlPrint.BlBase();
            table = bl.GetDataTable(kod);
            if (rbNumber.Checked == true)
                FillTableByNumber(kod, table);
            if (rbDate.Checked == true)
                FillTableByDate(kod, table);
           // tblPrint.Hide();           
            tblPrint.Show();
           number = i;
        }

        private void FillTableByNumber(string kod, DataTable table)
        {
            if (table.Rows[0]["peruk"] != null && string.IsNullOrEmpty(table.Rows[0]["mishna"].ToString()))
            {
                FillTablesPerek(kod, table);
            }
            else if (table.Rows[0]["mishna"].ToString() != null)
            {
                FillTableMishna(kod, table);
            }
        }

        private void FillTableMishna(string kod, DataTable table)
        {
            tblPrint.RowCount = rowNumber;
            tblPrint.Size = new Size(550, 600);
            tblPrint.ColumnCount = 7;
            // = continues * 8 * tblPrint.ColumnCount;
           // count = continues* tblPrint.RowCount * tblPrint.ColumnCount;
            count = numbers + (tblPrint.RowCount * tblPrint.ColumnCount);
            if (continues == 1)
                count -= 1;
            try
            {
                while (numbers < count)
                {
                    countLine = 0;
                    Label label = new Label();
                    //label.TextAlign = ContentAlignment.MiddleRight;
                    //Label labelSecond = new Label();
                    label.AutoSize = true;
                    //label.Font = new Font("Gisha", 6, FontStyle.Bold);
                    label.TextAlign = ContentAlignment.TopLeft;
                    // count = continues * tblPrint.RowCount * tblPrint.ColumnCount;
                    numbers = int.Parse(table.Rows[k]["number"].ToString());
                    label.Text = numbers.ToString();
                    while (table.Rows[k]["number"].ToString() == table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + "  " + table.Rows[k]["peruk"].ToString() + "  " + table.Rows[k]["mishna"].ToString();
                        k++;
                        countLine++;
                    }
                    if (countLine > 11)
                    {
                        rowNumber = 3;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 8)
                    {
                        rowNumber = 4;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 6)
                    {
                        rowNumber = 5;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 4)
                    {
                        rowNumber = 6;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 3)
                    {
                        rowNumber = 7;
                        tblPrint.RowCount = rowNumber;
                    }
                    if (table.Rows[k]["number"].ToString() != table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + " " + table.Rows[k]["peruk"].ToString() + " " + table.Rows[k]["mishna"].ToString();
                        k++;
                    }
                    //if (countLine > 5)
                    //{
                    //    rowNumber = 5;
                    //    count = continues * tblPrint.RowCount * tblPrint.ColumnCount;
                    //}
                    tblPrint.Controls.Add(label);
                }
            }
            catch (Exception)
            {
              
            }
           
        }

        private void FillTablesPerek(string kod,DataTable table)
        {
            //tblPrint.ColumnCount = 7;
            //tblPrint.RowCount = 8;

            tblPrint.Size = new Size(550, 600);
            //if (number < countFile)
            //{
            //    if (continues == 1)
            //        numberloop = number + continues * 174;
            //    else if (continues == 2)
            //        numberloop = number + continues * 110;
            //    else if (continues == 3)
            //        numberloop = number + continues * 87;
            //    else if (continues == 4)
            //        numberloop = number + continues * 69;
            //    else if (continues == 4)
            //        numberloop = number + continues * 69;
            //    else if (continues == 5)
            //        numberloop = number + continues * 55;
            //    else if (continues == 6)
            //        numberloop = number + continues * 46;
            //    else if (continues == 7)
            //        numberloop = number + continues * 43;
            //    else if (continues == 8)
            //        numberloop = number + continues * 41;
            //    else if (continues == 9)
            //        numberloop = number + continues * 37;
            //    else if (continues == 10)
            //        numberloop = number + continues * 7;
            //}
            //else if (number>=countFile)
            //{
            //    MessageBox.Show("אין עוד ערכים להציג");
            //    //lbContinue.Text = 10.ToString();
            //}
            //for (i = number + 1; i <= numberloop;/*int.Parse(table.Rows[i]["number"].ToString()).CompareTo(number+58)*/)
            //{
            //    if (i >= countFile - 1)
            //    {
            //        break;
            //    }
            //    Label label = new Label();
            //    label.AutoSize = true;
            //    label.TextAlign = ContentAlignment.TopLeft;
            //    //if (continues > 5)
            //    //    label.Font = new Font("Gisha", 7, FontStyle.Bold);
            //        //label.RightToLeft = 
            //        //label.TextAlign = ContentAlignment.MiddleCenter;
            //        if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 3]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 4]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 5]["number"].ToString())
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"].ToString() + "\n" + table.Rows[i + 3]["masechet_name"].ToString() + " " + table.Rows[i + 3]["peruk"] + "\n" + table.Rows[i + 4]["masechet_name"] + " " + table.Rows[i + 4]["peruk"] + "\n" + table.Rows[i + 5]["masechet_name"] + " " + table.Rows[i + 5]["peruk"];
            //        i += 6;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 3]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 4]["number"].ToString())
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"].ToString() + "\n" + table.Rows[i + 3]["masechet_name"].ToString() + " " + table.Rows[i + 3]["peruk"] + "\n" + table.Rows[i + 4]["masechet_name"] + " " + table.Rows[i + 4]["peruk"];
            //        i += 5;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 3]["number"].ToString())
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"].ToString() + "\n" + table.Rows[i + 3]["masechet_name"].ToString() + " " + table.Rows[i + 3]["peruk"];
            //        i += 4;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString())
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"];
            //        i += 3;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString())
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"] + " " + table.Rows[i + 1]["peruk"].ToString();
            //        i += 2;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() + table.Rows[i + 3]["masechet_name"] + " " + table.Rows[i + 3]["peruk"])
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\r\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"];
            //        i += 4;
            //    }
            //    else
            //    {
            //        label.Text = table.Rows[i]["number"].ToString() + "\r\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString();
            //        i++;
            //    }
            //    tblPrint.Controls.Add(label);
            //    (label).Show();
            //}
            count = numbers + (tblPrint.RowCount * tblPrint.ColumnCount);
            if (continues == 1)
                count -= 1;
            try
            {
                while (numbers < count)
                {
                    tblPrint.RowCount = rowNumber;
                    Label label = new Label();
                    //label.TextAlign = ContentAlignment.MiddleRight;
                    //Label labelSecond = new Label();
                    label.AutoSize = true;
                    //label.Font = new Font("Gisha", 6, FontStyle.Bold);
                    label.TextAlign = ContentAlignment.TopLeft;
                    // count = continues * tblPrint.RowCount * tblPrint.ColumnCount;
                    numbers = int.Parse(table.Rows[k]["number"].ToString());
                    label.Text = numbers.ToString();
                    countLine = 0;
                    while (table.Rows[k]["number"].ToString() == table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + "  " + table.Rows[k]["peruk"].ToString();
                        k++;
                        countLine++;
                    }
                    if (countLine > 3)
                    {
                        rowNumber = 7;
                        tblPrint.RowCount = rowNumber;
                    }
                    if (table.Rows[k]["number"].ToString() != table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + " " + table.Rows[k]["peruk"].ToString() + " " + table.Rows[k]["mishna"].ToString();
                        k++;
                    }
                    //if (countLine > 5)
                    //{
                    //    rowNumber = 5;
                    //    count = continues * tblPrint.RowCount * tblPrint.ColumnCount;
                    //}
                    tblPrint.Controls.Add(label);
                }
            }
            catch
            {

            }
        }

        private void btnContinued(object sender, EventArgs e)
        {
            if(clicked==true)
            {
                BlPrint.BlBase bl = new BlPrint.BlBase();
                DataTable table = bl.UntilNumber(kod);
                Continued(table, number);
            }
            else
            {
                MessageBox.Show("כדי להתחיל את פעולת התכנית יש ללחוץ על התחלה");
            }
        }

        public void Continued(DataTable table,int number)
        {
            continues++;
            //txtContinue.Text = continues.ToString();
            lbContinue.Text = continues.ToString();
            FillTables(kod);
                //}
        }
        public int maxFiles(string kod)
        {
            BlPrint.BlBase bl = new BlPrint.BlBase();
            int max = bl.MaxFile(kod);
            return max;
        }

       // private void btnSavePDF(object sender, EventArgs e)
        //{
            //SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.Filter = "Pdf|*.pdf";
            //saveFile.FileName = "חבורת משנה";
            //if(saveFile.ShowDialog()==DialogResult.OK)
            //using (Bitmap printImage = new Bitmap(tblPrint.Width, tblPrint.Height))
            //{
            //    tblPrint.DrawToBitmap(printImage, new Rectangle(8, 37, 675, 646));
            //    PrintPreviewDialog print = new PrintPreviewDialog();
            //    print.Document = printDoc1;
            //    printImage.Save(@"D:\Imegestor", System.Drawing.Imaging.ImageFormat.Jpeg);

            //}
            //Bitmap memoryImage = new Bitmap(675, 646);
            //this.DrawToBitmap(memoryImage, new Rectangle(new Point(tblPrint.Location.X, tblPrint.Location.Y), tblPrint.Size));
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            ////memoryGraphics.CopyFromScreen(new Point(tblPrint.Location.X, tblPrint.Location.Y), tblPrint.Size);
            //Graphics graphics = tblPrint.CreateGraphics();
            //Size formSize = tblPrint.ClientSize;
            //Bitmap bitmap = new Bitmap(formSize.Width, formSize.Height, graphics);
            //Point tblPrintLocation = PointToScreen(tblPrint.Location);
            //graphics.CopyFromScreen(tblPrintLocation.X, tblPrintLocation.Y, tblPrint.Size.Width, tblPrint.Size.Height, formSize);
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            // printPreviewDialog1.ShowDialog();
        //    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4",tblPrint.Size.Width,tblPrint.Size.Height);
        //    printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
        //    int count = tblPrint.RowCount;
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.ShowDialog();
        //}

        //private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    int row = 0;
        //    int varticalOffest = tblPrint.Bounds.Top;
        //    int xTblPrint = tblPrint.Location.X;
        //    int yTblPrint = tblPrint.Location.Y;
        //    try
        //    {
        //        foreach (var item in tblPrint.GetRowHeights())
        //        {
        //            int columns = 0;
        //            int horizontalOffset = tblPrint.Bounds.Left;
        //            foreach (var item1 in tblPrint.GetColumnWidths())
        //            {
        //                Rectangle rectangle = new Rectangle(horizontalOffset, varticalOffest, item1, item);
        //                horizontalOffset += item1;
        //                columns++;
        //                Pen pen = new Pen(Color.Black, 1);
        //                e.Graphics.DrawRectangle(pen, rectangle);
        //            }
        //            varticalOffest += item;
        //            row++;
        //        }
        //        int count = 0;
        //        foreach (Control item in tblPrint.Controls)
        //        {
        //            int xPos = item.Location.X + xTblPrint;
        //            int yPos = item.Location.Y + yTblPrint;
        //            float width = item.Width;
        //            float height = item.Height;
        //            string font = item.Font.Name;
        //            float fontSize = item.Font.Size;
        //            string fontStyle = item.Font.Style.ToString();
        //            string filedValue = item.Text;
        //            e.Graphics.DrawString(filedValue, item.Font, new SolidBrush(item.ForeColor), new RectangleF(xPos, yPos, width, height));
        //            count++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        TableLayoutPanel tablePrint = new TableLayoutPanel();
        private void btnPrint(object sender, EventArgs e)
        {
            tablePrint = tblPrint;
            //    using(Bitmap printImage=new Bitmap(tblPrint.Width, tblPrint.Height))
            //    {
            //        tblPrint.DrawToBitmap(printImage, new Rectangle(0, 0, printImage.Width+10, printImage.Height));
            //        printPreviewDialog1.Document = printDocument1;
            //        printDocument1.PrintPage += PrintDoc_PrintPage;
            //        printPreviewDialog1.ShowDialog
            //this.Hide();
            TableForm tableForm = new TableForm(lbContinue,nameUser);
            tableForm.Controls.Add(tablePrint);
            tableForm.Show();
           // Form1 form1 = new Form1();
            //this.Controls.Add(tblPrint);
            // this.Close();
        }

        public void FillTableByDate(string kod,DataTable table)
        {
            Calendar calendar = new HebrewCalendar();
            DateTime date = DateTime.Parse(table.Rows[0]["date"].ToString());
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CreateSpecificCulture("he-IL");
            ci.DateTimeFormat.Calendar = new System.Globalization.HebrewCalendar();
            //string day = date.Day.ToString(ci);
            //string year = date.Year.ToString(ci);
            //string month = date.Month.ToString(ci);
            //string date1 = day + " " + month + " " + year;
            string dateHebrew = date.ToString(ci);
            if (table.Rows[0]["peruk"] != null && string.IsNullOrEmpty(table.Rows[0]["mishna"].ToString()))
            {
                FillTableByPerekDate(kod, table);
            }
            else if (table.Rows[0]["mishna"].ToString() != null)
            {
                FillTableByMishnaDate(kod, table);
            }
        }

        private void FillTableByMishnaDate(string kod, DataTable table)
        {
            tblPrint.RowCount = rowNumber;
            tblPrint.Size = new Size(550, 600);
            tblPrint.ColumnCount = 7;
            // = continues * 8 * tblPrint.ColumnCount;
            // count = continues* tblPrint.RowCount * tblPrint.ColumnCount;
            count = numbers + (tblPrint.RowCount * tblPrint.ColumnCount);
            if (continues == 1)
                count -= 1;
            try
            {
                while (numbers < count)
                {
                    countLine = 0;
                    Label label = new Label();
                    //label.TextAlign = ContentAlignment.MiddleRight;
                    //Label labelSecond = new Label();
                    label.AutoSize = true;
                    label.TextAlign = ContentAlignment.TopLeft;
                    // count = continues * tblPrint.RowCount * tblPrint.ColumnCount;
                    numbers = int.Parse(table.Rows[k]["number"].ToString());
                    DateTime date = DateTime.Parse(table.Rows[k]["date"].ToString());
                    System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CreateSpecificCulture("he-IL");
                    ci.DateTimeFormat.Calendar = new System.Globalization.HebrewCalendar();
                    string dateHebrew = date.ToString(ci);
                    //dateHebrew = dateHebrew.Substring(0, 13);
                    int indexZero = dateHebrew.IndexOf("0");
                    dateHebrew = dateHebrew.Substring(0, indexZero);
                    label.Text = dateHebrew.ToString();
                    while (table.Rows[k]["number"].ToString() == table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + "  " + table.Rows[k]["peruk"].ToString() + "  " + table.Rows[k]["mishna"].ToString();
                        k++;
                        countLine++;
                    }
                    if (countLine > 11)
                    {
                        rowNumber = 3;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 8)
                    {
                        rowNumber = 4;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 6)
                    {
                        rowNumber = 5;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 4)
                    {
                        rowNumber = 6;
                        tblPrint.RowCount = rowNumber;
                    }
                    else if (countLine > 3)
                    {
                        rowNumber = 7;
                        tblPrint.RowCount = rowNumber;
                    }
                    if (table.Rows[k]["number"].ToString() != table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + " " + table.Rows[k]["peruk"].ToString() + " " + table.Rows[k]["mishna"].ToString();
                        k++;
                    }
                    tblPrint.Controls.Add(label);
                }
            }
            catch (Exception)
            {

            }
        }

        private void FillTableByPerekDate(string kod, DataTable table)
        {

            //tblPrint.ColumnCount = 7;
            //tblPrint.RowCount = 8;

            //tblPrint.Size = new Size(550, 600);
            //if (number < countFile)
            //{
            //    if (continues == 1)
            //        numberloop = number + continues * 174;
            //    else if (continues == 2)
            //        numberloop = number + continues * 110;
            //    else if (continues == 3)
            //        numberloop = number + continues * 87;
            //    else if (continues == 4)
            //        numberloop = number + continues * 69;
            //    else if (continues == 4)
            //        numberloop = number + continues * 69;
            //    else if (continues == 5)
            //        numberloop = number + continues * 55;
            //    else if (continues == 6)
            //        numberloop = number + continues * 46;
            //    else if (continues == 7) 
            //        numberloop = number + continues * 43;
            //    else if (continues == 8)
            //        numberloop = number + continues * 41;
            //    else if (continues == 9)
            //        numberloop = number + continues * 37;
            //    else if (continues == 10)
            //        numberloop = number + continues * 7;
            //}
            //else if (number >= countFile)
            //{
            //    MessageBox.Show("אין עוד ערכים להציג");
            //    //lbContinue.Text = 10.ToString();
            //}
            //for (i = number + 1; i <= numberloop;/*int.Parse(table.Rows[i]["number"].ToString()).CompareTo(number+58)*/)
            //{
            //    if (i >= countFile - 1)
            //    {
            //        break;
            //    }
            //    DateTime date = DateTime.Parse(table.Rows[i]["date"].ToString());
            //    System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CreateSpecificCulture("he-IL");
            //    ci.DateTimeFormat.Calendar = new System.Globalization.HebrewCalendar();
            //    date = date.Date;
            //    string dateHebrew = date.ToString(ci);
            //    // dateHebrew = dateHebrew.Substring(0,13);
            //    int indexZero = dateHebrew.IndexOf("0");
            //    dateHebrew = dateHebrew.Substring(0, indexZero);
            //    Label label = new Label();
            //    label.AutoSize = true;
            //    label.TextAlign = ContentAlignment.TopLeft;
            //    if (continues > 5) 
            //    {
            //        label.Font = new Font("Gisha", 6, FontStyle.Bold);
            //    }
            //    //label.RightToLeft = 
            //    //label.TextAlign = ContentAlignment.MiddleCenter;
            //    if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 3]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 4]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 5]["number"].ToString())
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\r\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"].ToString() + "\n" + table.Rows[i + 3]["masechet_name"].ToString() + " " + table.Rows[i + 3]["peruk"] + "\n" + table.Rows[i + 4]["masechet_name"] + " " + table.Rows[i + 4]["peruk"] + "\n" + table.Rows[i + 5]["masechet_name"] + " " + table.Rows[i + 5]["peruk"];
            //        i += 6;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 3]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 4]["number"].ToString())
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\r\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"].ToString() + "\n" + table.Rows[i + 3]["masechet_name"].ToString() + " " + table.Rows[i + 3]["peruk"] + "\n" + table.Rows[i + 4]["masechet_name"] + " " + table.Rows[i + 4]["peruk"];
            //        i += 5;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 3]["number"].ToString())
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\r\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"].ToString() + "\n" + table.Rows[i + 3]["masechet_name"].ToString() + " " + table.Rows[i + 3]["peruk"];
            //        i += 4;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString())
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\r\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"];
            //        i += 3;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString())
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"] + " " + table.Rows[i + 1]["peruk"].ToString();
            //        i += 2;
            //    }
            //    else if (table.Rows[i]["number"].ToString() == table.Rows[i + 1]["number"].ToString() && table.Rows[i]["number"].ToString() == table.Rows[i + 2]["number"].ToString() + table.Rows[i + 3]["masechet_name"] + " " + table.Rows[i + 3]["peruk"])
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString() + "\r\n" + table.Rows[i + 1]["masechet_name"].ToString() + " " + table.Rows[i + 1]["peruk"].ToString() + "\r\n" + table.Rows[i + 2]["masechet_name"].ToString() + " " + table.Rows[i + 2]["peruk"];
            //        i += 4;
            //    }
            //    else
            //    {
            //        label.Text = dateHebrew + "\n" + table.Rows[i]["masechet_name"].ToString() + " " + table.Rows[i]["peruk"].ToString();
            //        i++;
            //    }
            //    tblPrint.Controls.Add(label);
            //    (label).Show();
            //}
            tblPrint.RowCount = rowNumber;
            tblPrint.Size = new Size(550, 600);
            tblPrint.ColumnCount = 7;
            // = continues * 8 * tblPrint.ColumnCount;
            // count = continues* tblPrint.RowCount * tblPrint.ColumnCount;
            count = numbers + (tblPrint.RowCount * tblPrint.ColumnCount);
            if (continues == 1)
                count -= 1;
            try
            {
                while (numbers < count)
                {
                    countLine = 0;
                    Label label = new Label();
                    //label.TextAlign = ContentAlignment.MiddleRight;
                    //Label labelSecond = new Label();
                    label.AutoSize = true;
                    label.TextAlign = ContentAlignment.TopLeft;
                    // count = continues * tblPrint.RowCount * tblPrint.ColumnCount;
                    numbers = int.Parse(table.Rows[k]["number"].ToString());
                    DateTime date = DateTime.Parse(table.Rows[k]["date"].ToString());
                    System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.CreateSpecificCulture("he-IL");
                    ci.DateTimeFormat.Calendar = new System.Globalization.HebrewCalendar();
                    string dateHebrew = date.ToString(ci);
                    //dateHebrew = dateHebrew.Substring(0, 13);
                    int indexZero = dateHebrew.IndexOf("0");
                    dateHebrew = dateHebrew.Substring(0, indexZero);
                    label.Text = dateHebrew.ToString();
                    while (table.Rows[k]["number"].ToString() == table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + "  " + table.Rows[k]["peruk"].ToString() + "  " + table.Rows[k]["mishna"].ToString();
                        k++;
                        countLine++;
                    }
                    if (countLine > 3)
                    {
                        rowNumber = 7;
                        tblPrint.RowCount = rowNumber;
                    }
                    if (table.Rows[k]["number"].ToString() != table.Rows[k + 1]["number"].ToString())
                    {
                        label.Text += "\n" + table.Rows[k]["masechet_name"].ToString() + " " + table.Rows[k]["peruk"].ToString() + " " + table.Rows[k]["mishna"].ToString();
                        k++;
                    }
                    tblPrint.Controls.Add(label);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnCloseForm(object sender, EventArgs e)
        {
            this.Close();   
        }
        private void btnIntrodaction(object sender, EventArgs e)
        {
            //lbInstructions.Show();
        }

        private void lbHide(object sender, EventArgs e)
        {
            //lbInstructions.Hide();
        }

        private void btnPrintTable(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        //private void lbContinue_Click(object sender, EventArgs e)
        //{

        //}
    }
}
