namespace BinarySearchAndSorting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures and Algorithms Practice Problem");
            Console.WriteLine("*********************");

            List<string> list = new List<string> { "Ram", "Bhole", "Shiv", "Khanha", "Durga", "Lakshmi" };
            Console.WriteLine("Unsorted List:");
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            List<string> sorted = MergeSorting.Sort(list);
            Console.WriteLine("Sorted List:");
            foreach (string s in sorted)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
}
