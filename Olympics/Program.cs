using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] scores = new double[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter the score of judge [{0}] : ", i + 1);
                scores[i] = double.Parse(Console.ReadLine());
            }

            double totalPoints = CalculateTotalPoints(scores);

            Console.WriteLine("\n\nThe contestant receives a total of {0:F2} points.", totalPoints);
        }

        static double CalculateTotalPoints(double[] scores)
        {
            double total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }

            return total;
        }
    }
}
