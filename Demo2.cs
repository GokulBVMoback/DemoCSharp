using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 2;
            int prime=1;
            Console.WriteLine("Enter the number:");
            num=int.Parse(Console.ReadLine());
            do
            {
                if(num==0||num==1)
                {
                    Console.WriteLine("0 and 1 is not Prime number");
                    Console.WriteLine("Please Re-Enter the number:");
                    num = int.Parse(Console.ReadLine());
                }
                prime = num % i;
                if (num != i)
                {
                    prime = num % i;
                    if (prime == 0)
                    {
                        Console.WriteLine(num + " Is Not Prime Number");
                        break;
                    }
                    else if(i>num)
                    {
                        Console.WriteLine(num + " Is Prime Number");
                    }
                }
                i++;
            }
            while (i <= num+1);
        }
    }
}
