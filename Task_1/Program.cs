//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [,] GetArrayRandomDouble(int row, int col)
            {
                double[,] array = new double [row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {

                        array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                return array;
            }

            

            int n;
            int m;

            Console.WriteLine("Введите число строк(n): ");
            bool ifParseOk = int.TryParse(Console.ReadLine(), out n);
            if (!ifParseOk)
            {
                Console.WriteLine("Введено неверное значение");
            }
            Console.WriteLine("Введите число столбцов(m): ");

            bool ifParseOk2 = int.TryParse(Console.ReadLine(), out m);
            if (!ifParseOk2)
            {
                Console.WriteLine("Введено неверное значение");
            }

            
            if (ifParseOk && ifParseOk2)
            {
                GetArrayRandomDouble(n, m);
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
        }
    }
}