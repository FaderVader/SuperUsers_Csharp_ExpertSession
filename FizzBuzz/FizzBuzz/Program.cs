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
            string msg = "";
            var liste = new Dictionary<int, string>(); 

            for (var i = 1; i <= 150; i++)
            {

                if (IsDivisibleBy5(i) && IsDivisibleBy3(i))
                {
                    msg = "FizzBuzz";
                }
                else if (IsDivisibleBy5(i))
                {
                    msg = "Buzz";
                }
                else if (IsDivisibleBy3(i))
                {
                    msg = "Fizz";
                }
                else if (IsDivisibleBy7(i))
                {
                    msg = "Jazz";
                }
                else
                {
                    msg = "";
                }
                liste.Add(i, msg);
                
            }
            foreach (var item in liste)
            {
                Console.WriteLine($"Number: {item.Key} {item.Value}");
            }
            Console.ReadKey();
        }

        static bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }

        static bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        static bool IsDivisibleBy7(int number)
        {
            return number % 7 == 0;
        }


    }
}
