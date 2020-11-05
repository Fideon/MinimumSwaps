using System;
using System.IO;

namespace MinimumSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            textWriter.WriteLine(res);

            textWriter.Flush();
            textWriter.Close();
        }

        static int minimumSwaps(int[] arr)
        {

            return arr[0];
        }
    }
}
