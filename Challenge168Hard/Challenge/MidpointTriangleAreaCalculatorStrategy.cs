using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge168Hard.Mathematics;

namespace Challenge168Hard.Challenge
{
    public class MidpointTriangleAreaCalculatorStrategy : IAreaCalculatorStrategy
    {
        public float CalculateArea(List<PointF> points)
        {
            List<Triangle> triangles = new List<Triangle>();
            PointF centerPoint = points.AveragePoints();

            points = new List<PointF>(points.OrderBy(p => p.Subtract(centerPoint).Angle()).ToArray());

            for (int i = 0; i < points.Count; i++)
            {
                Triangle outTriangle = new Triangle(
                    centerPoint,
                    points[i],
                    points[(i + 1) % points.Count]);
                triangles.Add(outTriangle);
            }
            return triangles
                .Select(t => t.Area)
                .Aggregate((a1, a2) => a1 + a2);
        }
    }
}
