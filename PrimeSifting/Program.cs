using System;
using Sieve;
using System.Collections.Generic;


namespace PrimeSifting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Prime Sifting");
            Console.WriteLine("=============");
            Console.WriteLine("Please input a number:");
            int inputNum = int.Parse(Console.ReadLine());
         
            List<int> primeNumbers = Filter.primes(inputNum);
            Console.WriteLine("These are the prime numbers: ");
            foreach(int number in primeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}