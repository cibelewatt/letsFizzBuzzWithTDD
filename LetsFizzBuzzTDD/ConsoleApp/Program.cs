using System;
using LetsFizzBuzz.Domain;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");
            Console.WriteLine("Se ele for divisível por 3, aparecerá Fizz");
            Console.WriteLine("Se ele for divisível por 5, aparecerá Buzz");
            Console.WriteLine("Se ele for divisível por 3 e 5, aparecerá FizzBuzz");
            Console.WriteLine("Não sendo divisível por 3 e 5, retornará o número digitado");
            Console.WriteLine("Enter a number");

            var input = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Returning: {FizzBuzzDomain.GetValue(input)}");
        }
    }
}
