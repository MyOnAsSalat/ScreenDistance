using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
namespace Distance.Core
{
    public class HookDistanceService
    {
        public delegate void ResultHandler(DistanceResult result);
        public event ResultHandler? Notify;
        public double Multiplier { get; set; } = 1.0d;
        public bool isSubscribed = false;
        private IKeyboardMouseEvents m_GlobalHook;      
        private bool isFisrt = true;
        private Point first = new Point();
        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);
        public bool EnableRightClick { get; set; } = true;
        public bool EnableLeftClick { get; set; } = true;
        public bool EnableMiddleClick { get; set; } = true;
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (CheckButton(e.Button))
            {
                if (isFisrt)
                {
                    GetCursorPos(ref first);
                    isFisrt = false;
                }
                else
                {
                    Point second = new Point();
                    GetCursorPos(ref second);
                    var result = Calculation.GetDistance(first,second, Multiplier);
                    Task.Run(()=> Notify?.Invoke(result));
                    isFisrt = true;
                }
            }

        }
        private bool CheckButton(MouseButtons button)
        {
            return (EnableRightClick && button == MouseButtons.Right) ||
                (EnableLeftClick && button == MouseButtons.Left) ||
                (EnableMiddleClick && button == MouseButtons.Middle);
        }
        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            isSubscribed = true;
        }
        public void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            m_GlobalHook.Dispose();
            isSubscribed = false;
        }
    }
}