using System;

namespace Primera
{
    class Program: Interface1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("If u want");
            int i = 10;
            int j = 15;
            for (i; i < j; i++)
            {
            Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public void Primer()
        {
            throw new NotImplementedException();
        }
    }
}
