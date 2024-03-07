namespace Schaakbord
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
                string[] testInfo = stdin.ReadLine().Split();

                int size = int.Parse(testInfo[1]);

                if (size < 4 || size > 25)
                {
                    stdout.WriteLine($"{test + 1} bordfout");
                    continue;
                }

                char rowLetter = testInfo[0][0];
                int row = (int)(rowLetter - (int)'a' + 1);
                int column = int.Parse(testInfo[0].Substring(1));
                if (column < 1 || column > size || row < 1 || row > size)
                {
                    stdout.WriteLine($"{test + 1} foute start");
                    continue;
                }

                int[] moveset = { 1, 2, 1, -2, -1, 2, -1, -2, 2, 1, 2, -1, -2, 1, -2, -1 };

                string uitvoer = $"{test + 1}";
                List<string> results = new List<string>();

                for (int i = 0; i < 8; i++)
                {
                    int newRow = row + moveset[2 * i];
                    int newColumn = column + moveset[2 * i + 1];

                    if (column > 0 || column <= size || row > 0 || row <= size)
                    {
                        results.Add($"{(char)(newRow + (int)'a' - 1)}{newColumn}");
                    }
                }

                results.Sort();
                foreach (var word in results)
                {
                    uitvoer += $" {word}";
                }

                stdout.WriteLine(uitvoer);
            }
        }
    }
}
