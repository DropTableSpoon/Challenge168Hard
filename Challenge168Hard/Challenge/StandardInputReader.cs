using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge168Hard.Challenge
{
    public class StandardInputReader : IInputReader
    {
        public IInputProvider InputProvider
        {
            get;
            private set;
        }

        public StandardInputReader(IInputProvider inputProvider)
        {
            InputProvider = inputProvider;
        }

        public List<PointF> ReadPoints()
        {
            int pointCount = Int32.Parse(InputProvider.ReadLine());
            List<PointF> pointList = new List<PointF>();
            pointCount.Times(delegate
            {
                pointList.Add(ReadPoint());
            });
            return pointList;
        }

        public PointF ReadPoint()
        {
            string point = InputProvider.ReadLine();
            float[] pointComponents = point
                .Split(',')
                .Select(s => Single.Parse(s))
                .ToArray();

            if (pointComponents.Length != 2)
            {
                throw new FormatException("A point can only have 2 components, X and Y.");
            }
            else
            {
                return new PointF(pointComponents[0], pointComponents[1]);
            }
        }
    }
}
