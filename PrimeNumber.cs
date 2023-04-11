using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSorting
{
    public class PrimeNumber
    {
        public void prime()
        {
            Console.WriteLine("Enter the Starting value:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending value:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = num1; i < num2; i++)
            {
                int flag = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0 && i > 1)
                {
                    Console.WriteLine($"{i} is prime no. ");
                }
            }
        }


    }
}
