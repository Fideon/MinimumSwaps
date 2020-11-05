using System;
using System.IO;

namespace MinimumSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int[] arr = new int[] { 4, 3, 1, 2 };

            int res = minimumSwaps(arr);

            //textWriter.WriteLine(res);

            //textWriter.Flush();
            //textWriter.Close();
        }

        static int minimumSwaps(int[] arr) // 4, 3, 1, 2  |  1, 2, 3 ,4
        {
            // 4 3 1 2  0
            // 2 3 1 4  1
            // 3 2 1 4  2
            // 1 2 3 4  3

            int swaps = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    int temp = arr[i];
                    int temp2 = arr[temp - 1];
                    arr[temp - 1] = temp;
                    arr[i] = temp2;
                    swaps++;
                    i = arr[i] == i + 1 ? i : i - 1;
                }
            }
            return swaps;
        }
    }
}
