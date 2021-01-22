using System;
using System.Linq;

namespace challengers_club_adventure
{
    public class Mini_Max_Sum
    {
        static void miniMaxSum(int[] arr) {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                sum += arr[i];
            }

            var min = arr.Min();
            var max = arr.Max();

            Console.WriteLine("{0} {1}", sum - max, sum - min);
        }

        static void Main(string[] args) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}