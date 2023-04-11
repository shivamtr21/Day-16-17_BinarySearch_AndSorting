using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSorting
{
    public class PrimePalindromSearch 
    {
        public void prime()
        {
            Console.WriteLine("Enter the Starting value:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending value:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
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
                    list.Add(i);
                    palindrome(i);


                }
            }

            foreach (int j in list)
            {
                int reverse = ReverseNumber(j);
                if (list.Contains(reverse))
                {
                    Console.WriteLine($"{j} and {reverse} are  prime and Anagram.");
                }

            }
        }

        public bool palindrome(int i)
        {
            int temp = i, rev = 0, rem;
            while (i > 0)
            {
                rem = i % 10;
                rev = rev * 10 + rem;
                i = i / 10;
            }

            if (temp == rev)
            {

                Console.WriteLine($"{temp} is prime no. and Palindrome");

            }
            return false;
        }


        public int ReverseNumber(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }
            return reverse;
        }


    }
}
