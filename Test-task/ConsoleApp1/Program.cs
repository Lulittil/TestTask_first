using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_task;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Area circle = new Area(2);
            Console.WriteLine($"Площадь круга {circle.area_circle()}");
            Area triangle_non = new Area(3,4,5);
            Console.WriteLine($"Площадь треугольника: {triangle_non.area_triangle()}");
            Console.WriteLine($"Площадь неизвестной фигуры: {circle.area_noname()}");
        }
    }
}
