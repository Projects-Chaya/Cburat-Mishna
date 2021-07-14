using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;

namespace WinFormPrint
{
    public partial class TableForm : Form
    {
        string path;
        DataTable dataTable = new DataTable();
        TableForm tableForm;
        PrintDocument printDocument = new PrintDocument();
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
        int nXDest, int nYDest, int nWidth, int nHeight,
        IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();

        public TableForm(Label label,string nameUser)
        {
            InitializeComponent();
          //  lbPage.Text ="עמ' "+ label.Text;
           // lbName.Location = new Point(550, 35);
            lbPage.Location = new Point(40, 35);
            labPage.Text = "עמ' " + label.Text;
            //lbName.Text = "שם: " + nameUser;
            labName.Text = "שם: " + nameUser;
           // if(nameUser.Length>15)
               labName.Location = new Point(40, 35);
            btnPrint.Click += new EventHandler(btnPrinter);
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocumentPrintPage);
        }
        private void button1_Click(object sender, EventArgs e)
        {//1
         //    Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
         //    Graphics graphics = Graphics.FromImage(bitmap as Image);
         //    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
         //    bitmap.Save(@"D:\סילבר\prints" +"." + ImageFormat.Png);
         //    MessageBox.Show("הקובץ נשמר");
         //2
         // Clipboard.Clear();
         //SendKeys.SendWait("{PRTSC}");
         //while (!Clipboard.ContainsImage())
         // {
         //   Thread.Sleep(500);
         //}
         //Bitmap bitmap =new Bitmap(Clipboard.GetImage());
         //bitmap.Save(@"D:\סילבר\prints" +"." + ImageFormat.Png);
            //btnSave.Hide();
            //Rectangle bound = this.Bounds;
            //Bitmap bitmap = new Bitmap(bound.Width,bound.Height);
            //Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.CopyFromScreen(new Point(bound.Left, bound.Top), Point.Empty, bound.Size);
            //bitmap.Save(@"D:\סילבר\CburatMishna" +"." + ImageFormat.Png);

        }
        private void btnPrinter(object sender, EventArgs e)
        {
            btnClose.Hide();
            btnPrint.Hide();
            CaptureScreen();
            printDocument.Print();
            btnClose.Show();
            btnPrint.Show();
            //this.Hide();
            //  printDocument.Print();
        }
        private void CaptureScreen()
        {
            //Graphics mygraphics = this.CreateGraphics();
            //Size s = this.Size;
            //memoryImage = new Bitmap(s.Width, s.Height,
            //mygraphics);
            //Graphics memoryGraphics = Graphics.FromImage(
            //memoryImage);
            //IntPtr dc1 = mygraphics.GetHdc();
            //IntPtr dc2 = memoryGraphics.GetHdc();
            //BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
            //this.ClientRectangle.Height, dc1, 0, 0,
            //13369376);
            //mygraphics.ReleaseHdc(dc1);
            //memoryGraphics.ReleaseHdc(dc2);
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void PrintDocumentPrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        //private void Image_Click(object sender, EventArgs e)
        //{

        //}

        //private void PictureLogo_Click(object sender, EventArgs e)
        //{

        //}

        //private void TableForm_Load(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void btnCloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void btnSaves(object sender, EventArgs e)
        //{
        //    btnPrint.Hide();
        //    SaveFileDialog saveFile = new SaveFileDialog();
        //    saveFile.FileName = "CburatMishna";
        //    saveFile.Filter = "Image חבורת משנה|*.png";
        //    saveFile.ShowDialog();
        //    System.IO.FileStream fs =
        // (System.IO.FileStream)saveFile.OpenFile();
        //    LocationFolder locationFolder = new LocationFolder();

        //    locationFolder.Show();

        //}
    }
}
