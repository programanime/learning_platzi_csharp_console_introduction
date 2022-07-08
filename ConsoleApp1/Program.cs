using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint age = 10;
            long population = 10000L;
            bool married = false;
            float cash = 10.4f;
            double money = 100000.4d;
            char c = 'c';
            string name = "daniel";
            var otherName = "molina";
            StringSample.StringMethods();
            
            Console.WriteLine("Hello i am the guy!");
            Console.WriteLine(age);
            Console.WriteLine(married);
            Console.WriteLine(cash);
            Console.WriteLine(money);
            Console.WriteLine(c);
            Console.WriteLine(name);
            Console.WriteLine(population);
            Console.WriteLine(otherName);
            
            SomeArrays.collections();
            SomeArrays.sample();
            SomeArrays.random();
            SomeNumbers.square();
            StringSample.sample();
            StringSample.casting();
        }
    }
}
