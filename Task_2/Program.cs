/*Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 * и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4*/

//17->такого числа в массиве нет

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void FindNumber(int[,] arr, int n, int m)
            {
                bool numFound = false;
                try
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            if (arr[i, j] == arr[n, m])
                            {
                                Console.WriteLine($"Элемент по заданным строке и стобцу: {arr[i, j]}");
                                numFound = true;
                                break;
                            }

                        }
                        if (numFound == true)
                        { 
                            break; 
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Такого элемента в массиве нет");
                }
            }


            int[,] Array = { { 1, 4, 7, 2, }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
            int n;
            int m;

            Console.WriteLine("Введите значение строки(n) в массиве: ");
            bool ifParseOk = int.TryParse(Console.ReadLine(), out n);
            if (!ifParseOk)
            {
                Console.WriteLine("Введено неверное значение");
            }
            Console.WriteLine("Введите число столбца(m) в массиве: ");

            bool ifParseOk2 = int.TryParse(Console.ReadLine(), out m);
            if (!ifParseOk2)
            {
                Console.WriteLine("Введено неверное значение");
            }

            if (ifParseOk && ifParseOk2)
                {
                    FindNumber(Array, n, m);
                }
            else
            {
                Console.WriteLine("Введено неверное значение");
            }

        }
    }
}