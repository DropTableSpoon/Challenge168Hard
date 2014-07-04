using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge168Hard.Mathematics
{
    public struct Triangle
    {
        public PointF[] Points
        {
            get;
            private set;
        }

        public PointF A
        {
            get
            {
                return Points[0];
            }
        }

        public PointF B
        {
            get
            {
                return Points[1];
            }
        }

        public PointF C
        {
            get
            {
                return Points[2];
            }
        }

        public float Area
        {
            get
            {
                return (float)Math.Abs(0.5 * A.Distance(B) * A.Distance(C) * Math.Sin(A.Subtend(B, C)));
            }
        }

        public Triangle(params PointF[] points)
            : this()
        {
            if (points.Length == 3)
            {
                Points = points;
            }
            else
            {
                throw new ArgumentException("A triangle must have exactly 3 defining points.", "points");
            }
        }
    }
}
