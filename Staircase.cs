using System;

namespace challengers_club_adventure
{
    public class Staircase
    {
        static void staircase(int n) {
            int spaces = n - 1;
            for (int r = 1; r <= n; r++) {
                
                // Write spaces
                for (int s = 0; s < spaces; s++) {
                    Console.Write(" ");
                }
                spaces--;

                // Write hashes
                for (int h = 0; h < r; h++) {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }    

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }
}
