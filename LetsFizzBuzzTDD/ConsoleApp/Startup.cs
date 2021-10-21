using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LetsFizzBuzz.Domain;
using Microsoft.Extensions.Hosting;


namespace ConsoleApp
{
    public class Startup : IHostedService
    {
        private readonly FizzBuzzDomain _fizz;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public Startup(FizzBuzzDomain fizz, CancellationTokenSource cancellationTokenSource)
        {
            _fizz = fizz;
            _cancellationTokenSource = cancellationTokenSource;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {


            Console.WriteLine("All Fizzbuzz results from Zero to One Hundred"); 

            for (int i = 0; i <= 100; i++)
            {
                var output = _fizz.GetValue(i);
                Console.WriteLine(output);
            }
            

            _cancellationTokenSource.Cancel();
            return ;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Parando a aplicação...");
            return;
        }
    }
}
