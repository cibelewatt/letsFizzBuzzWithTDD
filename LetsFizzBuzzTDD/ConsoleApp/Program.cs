using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions.Common;
using LetsFizzBuzz.Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;

namespace ConsoleApp
{
    public class Program
    {
        private static readonly CancellationTokenSource tokenSource = new();
        static Task Main(string[] args)
        {
        
            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder.ConfigureServices((_, services) =>
            {
                services.AddTransient<FizzBuzzDomain>();
                services.AddHostedService<Startup>();
                services.AddSingleton(tokenSource);
            });

            using var host = hostBuilder.Build();

            return host.RunAsync(tokenSource.Token);
        }

        //Console.WriteLine("Welcome to FizzBuzz");
        //Console.WriteLine("Number divisible by 3, will appear Fizz");
        //Console.WriteLine("Number divisible by 5, will appear Buzz");
        //Console.WriteLine("Number both divisible by 3 and 5, will appear FizzBuzz");
        //Console.WriteLine("Number cannot be divisible by 3 and 5, will appear the number");
        //Console.WriteLine("Enter a number");

        //var input = Convert.ToInt32(Console.ReadLine());

        //Console.Write($"Returning: {FizzBuzzDomain.GetValue(input)}");
    }
    
}
