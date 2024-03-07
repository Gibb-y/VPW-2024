namespace Zonnepanelen
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
                int frame = int.Parse(stdin.ReadLine());
                int D = int.Parse(stdin.ReadLine());
                string[] measure = stdin.ReadLine().Split();
                string uitvoer = $"{test + 1}";
                for (int segment = 0; segment < D-frame+1; segment++)
                {
                    int sum = 0;
                    for (int uur = 0; uur < frame; uur++)
                    {
                        sum += int.Parse(measure[uur+segment]);
                    }

                    uitvoer += $" {sum}";
                }
                stdout.WriteLine(uitvoer);
            }
        }
    }
}
