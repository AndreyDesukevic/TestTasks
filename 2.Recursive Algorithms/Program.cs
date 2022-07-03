using System;

namespace _2.Recursive_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нахождения числа из последовательности Фибоначчи (1)" +
                "\nВозведения любого числа в любую целую степень(2)");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Fib();
                    break;
                case 2:
                    Degree();
                    break;
                default:
                    Console.WriteLine("Нет такой функции");
                    break;
            }
        }
        static void Fib()
        {
            Console.WriteLine("Введите порядковый номер числа из последовательностии Фибоначчи:");
            int fibNum = int.Parse(Console.ReadLine());
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
            int fib = Fibonachi(fibNum);
            Console.WriteLine($"{fibNum} число ибоначчи:{fib}");

        }
        static void Degree()
        {
            Console.WriteLine("Введите число возводимое в степень:");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень:");
            int degree = int.Parse(Console.ReadLine());
            double Degree2(int value, int degree)
            {
                if (degree == 0)
                    return 1;
                if (degree > 0)
                    return Degree2(value, degree - 1) * value;
                return (1.0/ Degree2(value, -degree));
            }
            double dgrResult = Degree2(value, degree);
            Console.WriteLine($"Ответ:{dgrResult}");
        }
    }
}
