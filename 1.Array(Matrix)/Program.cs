using System;

namespace _1.Array_Matrix_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождение суммы чисел главной диагонали Рандомной матрицы (1)" +
                "\nНахождение суммы чисел главной диагонали Своей матрицы(2)" +
                "\nНахождение суммы чисел кратных 3(3)");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    RandomMatrix();
                    break;
                case 2:
                    EnterMatrix();
                    break;
                case 3:
                    Sum3();
                    break;
                default:
                    Console.WriteLine("Нет такого пункта");
                    break;
            }
        }
        static void RandomMatrix()
        {
            Console.WriteLine("Ведите высоту матрицы:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите ширину матрицы:");
            int width = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[,] matrix = new int[height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    matrix[y, x] = rnd.Next(-10, 10);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write($"{matrix[y, x]}\t");
                Console.WriteLine();
            }

            int sumDiagonal = 0;
            int sum3 = 0;
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    if (matrix[y, x] % 3 == 0)
                        sum3 += matrix[y, x];
                    if (y == x)
                        sumDiagonal += matrix[y, x];
                }
            Console.WriteLine($"Сумма = {sumDiagonal}\nСумма чисел кратных 3={sum3}");
        }
        static void EnterMatrix()
        {
            Console.WriteLine("Ведите высоту матрицы:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите ширину матрицы:");
            int width = int.Parse(Console.ReadLine());
            int[,] matrix = new int[height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Console.WriteLine($"Введите число {y + 1}строки,{x + 1}столбца ");
                    matrix[y, x] = int.Parse(Console.ReadLine());
                }
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                    Console.Write($"{matrix[y, x]}\t");
                Console.WriteLine();
            }
            int sumDiagonal = 0;
            int sum3 = 0;
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    if (matrix[y, x] % 3 == 0)
                        sum3 += matrix[y, x];
                    if (y == x)
                        sumDiagonal += matrix[y, x];
                }
            Console.WriteLine($"Сумма = {sumDiagonal}\nСумма чисел кратных 3={sum3}");
        }
        static void Sum3()
        {
            Console.WriteLine("Ведите длинну массива чисел:");
            int lengthArray = int.Parse(Console.ReadLine());
            int[] array = new int[lengthArray];
            for (int x = 0; x < lengthArray; x++)
            {
                Console.WriteLine($"Введите {x + 1} число массива");
                array[x] = int.Parse(Console.ReadLine());
            }
            int sum3 = 0;
            for (int x = 0; x < lengthArray; x++)
            {
                Console.Write($"{array[x]}\t");
                if (array[x] % 3 == 0)
                    sum3 += array[x];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел кратных 3={sum3}");
        }
    }
}
