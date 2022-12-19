using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Xml.Linq;
using System.Windows;
namespace CursorDistance
{
    public partial class Overlay : Form
    {
        public string meters = "1";
        public Overlay()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr window, int index);
        IntPtr handle = FindWindowByCaption(IntPtr.Zero, GetWindowName());

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        // Making basic RECT struct for GetWindowRect function.
        public struct RECT
        {
            public int left, top, right, bottom;
        }
        // Making the graphics object.
        System.Drawing.Graphics g;
        private void Overlay_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Top = 0;
            this.Left = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = System.Drawing.Color.Black;
            this.TransparencyKey = System.Drawing.Color.Black;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            this.TopMost = true;
            Form1.CheckForIllegalCrossThreadCalls = false;
            Thread PrePaintThread = new Thread(new ThreadStart(prepaint));
            PrePaintThread.Start();
        }
        public bool isWorking = true;
        private void prepaint()
        {
            while (isWorking)
            {
                this.Refresh();
                //AutoHiding();
                /* Refresh rate is 50ms */
                System.Threading.Thread.Sleep(50);
            }
        }
        private void painttext(System.Drawing.Graphics g)
        {
            /* Make a new font object for drawing */
            Font bigFont = new Font("Arial", 20);
            /* Make a colored brush for drawing text */
            Brush mybrush = new SolidBrush(Color.White);
            /* Draw 'Hello, World' at position 50, 50 of the game window */
            g.DrawString(meters, bigFont, mybrush, Screen.PrimaryScreen.Bounds.Width/2, Screen.PrimaryScreen.Bounds.Height/5);
        }

        private void Overlay_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            painttext(g);
        }
        private static string GetWindowName()
        {
           return Process.GetProcesses().First(x => x.MainWindowTitle.Contains("War Thunder")).MainWindowTitle;
        }
        private void AutoHiding()
        {
            IntPtr curhandle = GetForegroundWindow();
            RECT outrect;
            GetWindowRect(handle, out outrect);
            this.Size = new Size(outrect.right - outrect.left, outrect.bottom - outrect.top);
            this.Top = outrect.top;
            this.Left = outrect.left;
            if (curhandle != handle)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}
