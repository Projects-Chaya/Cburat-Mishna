using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinFormPrint
{
    public partial class LocationFolder : Form
    {
        string path;
        public LocationFolder()
        {
            InitializeComponent();
        }
            [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
            public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

            //public static void Move(FolderBrowserDialog folder)
            //{
            //    const short SWP_NOMOVE = 0X2;
            //    const short SWP_NOSIZE = 1;
            //    const short SWP_NOZORDER = 0X4;
            //    const int SWP_SHOWWINDOW = 0x0040;

            //    Process[] processes = Process.GetProcesses(".");
            //    foreach (var process in processes)
            //    {
            //        var handle = process.MainWindowHandle;
            //    var form = Control.FromHandle.handle(folder);

            //        if (form == null) continue;

            //        SetWindowPos(folder, 0, 0, 0, form.Bounds.Width, form.Bounds.Height, SWP_NOZORDER | SWP_SHOWWINDOW);
            //    }
            //}

        private void LocationFolder_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show("chburatMisna.Png בחירת מקום קובץ");
         //   //FolderBrowserDialog folder = new FolderBrowserDialog();
         //  // folder.Show(GetHandleFromWindow(parentWindow));
         //   //folder.RootFolder = System.Environment.SpecialFolder.MyComputer;
         //   MessageBox.Show("הערה: יש להזיז את החלון הבא הצידה");
         //  // if (folder.ShowDialog() == DialogResult.OK)
         // //  {
         //       //path = folder.SelectedPath;
         ////   }
         //   Rectangle bound = this.Bounds;
         //   Bitmap bitmap = new Bitmap(bound.Width, bound.Height);
         //   Graphics graphics = Graphics.FromImage(bitmap);
         //   graphics.CopyFromScreen(new Point(bound.Left, bound.Top), Point.Empty, bound.Size);
         //   bitmap.Save(path + "\\Chburatmishna.Png", ImageFormat.Png);
         //   MessageBox.Show("הקובץ נשמר במיקום הנבחר");
         //   //Move(folder);

        }
    }
}
