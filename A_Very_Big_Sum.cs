using System;
using System.IO;

namespace challengers_club_adventure
{
    public class A_Very_Big_Sum
    {
        static long aVeryBigSum(long[] ar) {
            long sum = 0;
            for(int i = 0; i < ar.Length; i++) {
                sum += ar[i];
            }
            
            return sum;
        }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
    }
}