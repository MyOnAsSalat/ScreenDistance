using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenDistance.UI
{
    public class Settings
    {
        public int FontSize { get; set; } = 20;
        public bool isShowAzimuth { get; set; } = true;
        public bool EnableRightClick { get; set; } = true;
        public bool EnableLeftClick { get; set; } = true;
        public bool EnableMiddleClick { get; set; } = true;
    }
}
