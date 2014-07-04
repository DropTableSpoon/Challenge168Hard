using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge168Hard.Challenge
{
    public interface IInputReader
    {
        IInputProvider InputProvider
        {
            get;
        }

        List<PointF> ReadPoints();
    }
}
