using System;
using System.Collections.Generic;
using System.Text;

namespace _4.OOP
{
    abstract class Figure
    {
        public int _param1;
        public int _param2;
       

       protected Figure(int param1)
        {
            _param1 = param1;
        }
        protected Figure(int param1, int param2) : this(param1)
        {
            _param2 = param2;
        }

        public virtual void Validation()
        {
            if (_param1>0&&_param2 == 0)
            {
                Console.WriteLine("Фигура существует!");
            }

            else
            {
                if (_param1 > 0 && _param2 > 0)
                    Console.WriteLine("Фигура существует!");

                else
                    Console.WriteLine("Фигура не существует!");
            }
           
        }
        public virtual void Area() => Console.WriteLine($"Площадь:{_param1 * _param2}");
        public virtual void Perimetr() => Console.WriteLine($"Периметр:{(_param1 +_param1)*2}");
    }
}
