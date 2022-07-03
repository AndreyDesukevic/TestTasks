using System;
using System.Collections.Generic;
using System.Text;

namespace _4.OOP
{
    class Circle : Figure
    {
        public const double Pi= 3.14159265;
        public Circle(int param1) : base(param1)
        {
        }
        public override void Area()=>Console.WriteLine($"Площадь:{Pi * Math.Pow(_param1, 2)}");
        public override void Perimetr() => Console.WriteLine($"Периметр:{2 * Pi * _param1}");
       
    }
}
