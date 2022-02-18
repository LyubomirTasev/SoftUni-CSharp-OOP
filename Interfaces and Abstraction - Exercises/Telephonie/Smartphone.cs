using System;
using System.Collections.Generic;
using System.Text;

namespace Telephonie
{
    public class Smartphone : ICalling
    {
        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url)
        {
            Console.WriteLine($"Browsing... {url}");
        }
    }
}
