using System;

namespace learnGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "wow";
            string b = a;
            b = b + " change";
            Console.WriteLine(a);
        }

        private static void foo(int[] arr)
        {
            int[] a = new int[] { 8, 0 };
            arr = a;
        }
    }
}
