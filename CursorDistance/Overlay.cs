using System.Runtime.InteropServices;
using System.Diagnostics;
namespace CursorDistance
{
    public partial class Overlay : Form
    {
        public int Meters { get; set; } = 0;
        public double Azimuth { get; set; } = 90d;
        public int FontSize { get; set; } = 20;
        public bool isShowAzimuth { get; set; } = true;
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

        Graphics g;
        private void Overlay_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Top = 0;
            this.Left = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            this.TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            Thread PrePaintThread = new Thread(new ThreadStart(PaintJobStart));
            PrePaintThread.Start();
        }
        public bool isWorking = true;
        private void PaintJobStart()
        {
            while (isWorking)
            {
                this.Refresh();
                //AutoHiding();
                /* Refresh rate is 50ms */
                Thread.Sleep(50);
            }
        }
        private void Draw(Graphics g)
        {
            /* Make a new font object for drawing */
            Font bigFont = new Font("Arial", FontSize);
            /* Make a colored brush for drawing text */
            Brush mybrush = new SolidBrush(Color.White);
            /* Draw 'Hello, World' at position 50, 50 of the game window */
            Point pos = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 5);
            g.DrawString(Meters.ToString(), bigFont, mybrush, pos.X,pos.Y );
            if(isShowAzimuth) 
                g.DrawString(Azimuth.ToString("#.#") + "º", bigFont, mybrush, pos.X, pos.Y + FontSize+4);
        }

        private void Overlay_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Draw(g);
        }
        private static string GetWindowName()
        {
           return Process.GetProcesses().First(x => x.MainWindowTitle.Contains("War Thunder")).MainWindowTitle;
        }
    }
}
