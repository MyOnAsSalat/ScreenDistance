using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Distance.Core
{
    public static class Calculation
    {
        public static DistanceResult GetDistance(Point first, Point second, double multiplier = 1.0d)
        {
            var dist = Math.Sqrt(Math.Pow(second.X - first.X, 2) + Math.Pow(second.Y - first.Y, 2));
            var xDiff = second.X - first.X;
            var yDiff = second.Y - first.Y;
            var angle = ((Math.Atan2(yDiff, xDiff) * 180 / Math.PI) + 450) % 360;
            var meters = dist * multiplier;
            return new DistanceResult() { Pixels = (int)dist, Meters = (int)meters, Azimuth = angle };
        }
    }
}
