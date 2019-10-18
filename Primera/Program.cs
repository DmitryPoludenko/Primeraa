using System;

namespace Primera
{
    class Program: Interface1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("If u want");
            int i;
            int j = 15;
            for (i = 10 ; i < j; i++)
            {
              
                Random rnd = new Random();
                
                Console.WriteLine(rnd.Next(0, 50));
            }
            
            Console.WriteLine("Im on it!");

            Evgeniy a = new Evgeniy();
            a.Met();

            Console.ReadLine();
        }

        public void Primer()
        {
            throw new NotImplementedException();
        }
    }
}
