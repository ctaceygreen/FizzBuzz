using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 50;
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.ReadLine();
        }


        public static string FizzBuzz(int N)
        {
            // 0 case, return 0?
            if(N == 0)
            {
                return "0";
            }
            string result = "";
            //If divisible by 3, print Fizz
            if(N % 3 == 0)
            {
                result += "Fizz";
            }

            //If divisible by 5, print Buzz
            //If both, FizzBuzz
            if(N % 5 == 0)
            {
                result += "Buzz";
            }
            //If none, then return the number??
            if(String.IsNullOrEmpty(result))
            {
                result = N.ToString();
            }
            return result;
        }
    }
}
