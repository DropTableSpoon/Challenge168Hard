using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge168Hard.Challenge
{
    public interface IInputProvider
    {
        string ReadLine(string prompt = null);
        void WriteLine(object line);
    }
}
