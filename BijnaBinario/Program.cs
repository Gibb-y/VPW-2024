using System.Runtime.ExceptionServices;

namespace BijnaBinario
{
        private static System.IO.TextReader stdin = Console.In;
        private static System.IO.TextWriter stdout = Console.Out;
    internal class Program
    {


        enum BinValue { Zero, One, Empty };
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\darek\\Downloads\\cat2\\cat2\\afronding\\voorbeeld5.invoer");
            StreamWriter sw = new StreamWriter("C:\\Users\\darek\\Downloads\\cat2\\cat2\\afronding\\voorbeeld5.uitvoer");
            int testAmount = int.Parse(stdin.ReadLine());

            for (int test = 0; test < testAmount; test++)
            {
                int dimension = int.Parse(stdin.ReadLine());

                BinValue[,] puzzle = new BinValue[dimension, dimension];

                for (int i = 0; i < dimension; i++)
                {
                    string[] row = stdin.ReadLine().Split();

                    for (int j = 0; j < dimension; j++)
                    {
                        string element = row[j];

                        switch(element)
                        {
                            case ".": puzzle[i, j] = BinValue.Empty;
                                break;
                            case "1":
                                puzzle[i, j] = BinValue.One;
                                break;
                            default:
                                puzzle[i, j] = BinValue.Zero;
                                break;
                        }
                    }
                }

                //alles is ingelezen => los puzzel op

                bool is_solved = false;

                while (!is_solved)
                {
                    for (int i = 0; i < dimension; i++)
                    {
                        BinValue[] row = new BinValue[dimension];
                        int emptySpaces = 0;
                        int emptySpaceIndex = 0;
                        int oneCount = 0;
                        for (int j = 0; j < dimension; j++)
                        {
                            row[j] = puzzle[i, j];
                            if (row[j] == BinValue.Empty)
                            {
                                emptySpaces++;
                                emptySpaceIndex = j;
                            }
                            else if (row[j] == BinValue.One)
                                oneCount++;
                        }

                        if (emptySpaces == 1)
                        {
                            if (oneCount > (dimension / 2) - 1)
                                puzzle[i, emptySpaceIndex] = BinValue.Zero;
                            else
                                puzzle[i, emptySpaceIndex] = BinValue.One;
                        }



                        for (int j = 0; j < dimension; j++)
                        {
                            BinValue currentValue = puzzle[i, j];
                            if (currentValue != BinValue.Empty)
                                continue;



                            
                        }
                    }
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
