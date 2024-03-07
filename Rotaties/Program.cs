namespace Rotaties
{
    internal class Program
    {
        enum Colours { W, G, Z }
        private static System.IO.TextReader stdin = Console.In;
        private static System.IO.TextWriter stdout = Console.Out;
        static void Main(string[] args)
        {
            int testAmount = int.Parse(stdin.ReadLine());

            for (int test = 0; test < testAmount; test++)
            {
                string[] testInfo = stdin.ReadLine().Split();
                int length = int.Parse(testInfo[0]);
                List<int> results = new List<int>();
                bool is_white = true;
                int lastWhite = 0;

                for (int house = 1; house < length + 1; house++)
                {

                    int cost = 0;
                    
                    for (int i = 0; i < length + 1; i++)
                    {
                        if (i < house)
                        {
                            if (testInfo[i] == "G")
                            {
                                cost++;
                            }
                            else if (testInfo[i] == "Z")
                            {
                                cost += 2;
                            }
                        }
                        else
                        {
                            if (testInfo[i] == "G")
                            {
                                cost += 2;
                            }
                            else if (testInfo[i] == "W")
                            {
                                cost++;
                            }
                        }
                    }

                    results.Add(cost);
                }

                stdout.WriteLine($"{test + 1} {results.Min()}");
            }
        }
    }
}
