using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge168Hard
{
    public static class PointExtensionMethods
    {
        public static float Distance(this PointF point, PointF remotePoint)
        {
            float
                dx = remotePoint.X - point.X,
                dy = remotePoint.Y - point.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public static PointF Add(this PointF point, PointF p)
        {
            return new PointF(point.X + p.X, point.Y + p.Y);
        }

        public static PointF Subtract(this PointF point, PointF p)
        {
            return new PointF(point.X - p.X, point.Y - p.Y);
        }

        public static float Angle(this PointF point)
        {
            return (float)Math.Atan2(point.Y, point.X);
        }

        public static float Subtend(this PointF point, PointF a1, PointF a2)
        {
            a1 = a1.Subtract(point);
            a2 = a2.Subtract(point);
            float angleA = a1.Angle(), angleB = a2.Angle();
            if (angleA > angleB)
            {
                float swap = angleA;
                angleA = angleB;
                angleB = swap;
            }
            return (float)((angleB - angleA + (Math.PI * 2)) % (Math.PI * 2));
        }
    }
}
