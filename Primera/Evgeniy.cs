using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    class Evgeniy : Interface1
    {
        public void Primer()
        {
            throw new NotImplementedException();
        }
        public string Stroka(string x)
        {
            return x;
        }
        public void Met()
        {
            Console.WriteLine("This is my own class!!!");
        }
    }
}
