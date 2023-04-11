using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAndSorting
{
    public class Anagram
    {

        public static void CheckAnagram()
        {
            string str1 = "abcd";
            string str2 = "dcba";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);


            //ch1.ToString; we can do this also
            string val1 = new string(ch1);// converting char to string and store in val1 in built string
            string val2 = new string(ch2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if (val1 == val2)
            {
                Console.WriteLine("It is an Anagram");
            }
            else { Console.WriteLine("It is not an Anagram"); }


        }

    }
}
