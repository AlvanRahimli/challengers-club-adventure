using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace challengers_club_adventure
{
    class Result_2
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int maxVal = candles.Max();
            
            int count = 0;
            for (int i = 0; i < candles.Count; i++) {
                if (candles[i] == maxVal) {
                    count++;
                }
            }
            
            return count;
        }
    }

    public class Birthday_Cake_Candles
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result_2.birthdayCakeCandles(candles);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}