using System;

namespace challengers_club_adventure
{
    public class Plus_Minus
    {
        static void plusMinus(int[] arr) {
            decimal negCount = 0, posCount = 0, zeroCount = 0;
            
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > 0) {
                    posCount++;
                } else if (arr[i] == 0) {
                    zeroCount++;
                } else if (arr[i] < 0) {
                    negCount++;
                }
            }
        
            decimal negRatio = Math.Round(negCount / arr.Length, 6);
            decimal posRatio = Math.Round(posCount / arr.Length, 6);
            decimal zeroRatio = Math.Round(zeroCount / arr.Length, 6);
        
            Console.WriteLine(posRatio);
            Console.WriteLine(negRatio);
            Console.WriteLine(zeroRatio);
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}