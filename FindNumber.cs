using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSorting
{
    public class FindNumber
    {

        public void call(int low, int high)
        {
            if (low > high)
            {
                Console.WriteLine("Number not found.");
                return;
            }

            int mid = (low + high) / 2;

            Console.WriteLine($"Is the number between {low} and {mid}? (y/n) ");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'y')
            {
                if (low == high)
                {
                    Console.WriteLine($"Your number is {high}");
                    return;
                }
                call(low, mid);
            }
            else
            {
                low = mid + 1;
                call(low, high);

            }




        }


    }
}
