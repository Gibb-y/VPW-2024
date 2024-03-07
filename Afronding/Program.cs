using System.IO;

namespace Afronding
{
    internal class Program
    {
        private static System.IO.TextReader stdin = Console.In;
        private static System.IO.TextWriter stdout = Console.Out;
        static void Main(string[] args)
        {
            int testAmount = int.Parse(stdin.ReadLine());

            for (int test = 0; test < testAmount; test++)
            {
                int priceAmount = int.Parse(stdin.ReadLine());

                double[] prices = new double[priceAmount];
                double[] pricesRounded = new double[priceAmount];
                string[] pricesString = stdin.ReadLine().Split();

                for (int i = 0; i < priceAmount; i++)
                {
                    prices[i] = double.Parse(pricesString[i].Replace(',', '.'));
                    pricesRounded[i] = Round(prices[i]);
                }

                double sumPrice = prices.Sum();
                double sumPriceRounded = Round(sumPrice);
                double sumRoundedPrices = pricesRounded.Sum();

                string sumP = (Math.Round(sumPrice, 2)).ToString().Replace('.', ',');
                if (sumP.Split(',').Count() == 1)
                {
                    sumP += ",00";
                }
                else if (sumP.Split(',')[1].Length == 1)
                {
                    sumP += "0";
                }

                string sumPR = (Math.Round(sumPriceRounded, 2)).ToString().Replace('.', ',');
                if (sumPR.Split(',').Count() == 1)
                {
                    sumPR += ",00";
                }
                else if (sumPR.Split(',')[1].Length == 1)
                {
                    sumPR += "0";
                }

                string sumRP = (Math.Round(sumRoundedPrices, 2)).ToString().Replace('.', ',');
                if (sumRP.Split(',').Count() == 1)
                {
                    sumRP += ",00";
                }
                else if (sumRP.Split(',')[1].Length == 1)
                {
                    sumRP += "0";
                }

                stdout.WriteLine($"{test + 1} {sumP} {sumPR} {sumRP}");
            }
        }

        static double Round(double input)
        {
            double remainder = input % 0.05;

            if (remainder <= 0.0200000001)
            {
                return input - remainder;
            }
            else
            {
                return input + (0.05 - remainder);
            }

        }
    }
}
