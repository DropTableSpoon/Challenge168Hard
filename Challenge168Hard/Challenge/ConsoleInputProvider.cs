using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge168Hard.Challenge
{
    public class ConsoleInputProvider : IInputProvider
    {
        public string ReadLine(string prompt = null)
        {
            if(prompt != null) 
               Console.Write(prompt);
            return Console.ReadLine();
        }

        public void WriteLine(object line)
        {
            Console.WriteLine(line);
        }
    }
}
