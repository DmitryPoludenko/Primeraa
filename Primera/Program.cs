using System;

namespace Example
{
    class Program: Interface1
    {
        static void Main(string[] args)
        {
            string evil = "Am I evil?";
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
            a.Stroka(evil);

            Console.ReadLine();
        }
    }
}
