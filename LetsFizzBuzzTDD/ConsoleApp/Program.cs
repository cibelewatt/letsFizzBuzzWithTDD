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

       
    }
    
}
