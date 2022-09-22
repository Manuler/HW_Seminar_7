// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [,] GetArray(int row, int col)
            {
                int[,] array = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {

                        array[i, j] = new Random().Next(1, 5);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                return array;
            }

            void GetArithmeticalMeanCol(int[,] arr)
            {
                string mean = "";
                double sum = 0;
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        sum += arr[j, i];
                    }
                    sum /= arr.GetLength(0);
                    mean += Math.Round(sum, 2) + " ";
                    sum = 0;
                }
                Console.WriteLine(mean);
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
                GetArithmeticalMeanCol(GetArray(n,m));
            }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }
        }
    }
}