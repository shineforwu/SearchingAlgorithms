using System;

namespace LinearSearch
{
    class Program
    {
        public static int Search(int[] arr, int x)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1,9, 3, 5, 120, 430,1222,15984,};
            int x = 1222;

            int result = Search(arr, x);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index " + result);
            Console.ReadKey();
        }
    }
}
