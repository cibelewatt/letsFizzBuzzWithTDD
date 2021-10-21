using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsFizzBuzz.Domain
{
    public class FizzBuzzDomain
    {
        public string GetValue(int input)
        {
            if (input % 3 != 0 && input % 5 != 0)
            {
                return input.ToString();
            }
            if (input % 3 == 0 && input % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input % 5 == 0)
            {
                return "Buzz";
            }
            else return input.ToString();
        }
    }
}
