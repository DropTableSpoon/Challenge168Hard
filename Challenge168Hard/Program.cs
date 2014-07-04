using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge168Hard.Challenge;

namespace Challenge168Hard
{
    public static class Program
    {
        public static PointF AveragePoints(this IEnumerable<PointF> points)
        {
            return new PointF(
                (float)points.Average(p => p.X),
                (float)points.Average(p => p.Y));
        }

        public static void Times(this int n, Action a)
        {
            for (int i = 0; i < n; i++)
            {
                a();
            }
        }

        public static void Main(string[] args)
        {
            IInputReader reader = new StandardInputReader(new ConsoleInputProvider());
            reader.InputProvider.WriteLine(new MidpointTriangleAreaCalculatorStrategy().CalculateArea(reader.ReadPoints()));
            Console.ReadKey();
        }
    }
}
