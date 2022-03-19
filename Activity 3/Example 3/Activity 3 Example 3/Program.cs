using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity_3_Example_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 180;
            int number2 = 150;
            int answer = gcd(number1, number2);
            Console.Out.WriteLine("The gcd of {0} and {1} is {2}", number1, number2, answer);
            Console.ReadLine();
        }

        private static int gcd(int n1, int n2)
        {
            if (n2 == 0)
            {
                return n1;
            }
            else
            {
                Console.Out.WriteLine("Not yet. Remainder is {0}", n1 % n2);
                return gcd(n2, n1 % n2);
            }
        }
    }
}
