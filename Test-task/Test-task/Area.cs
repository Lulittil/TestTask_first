using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    public class Area
    {
        private double radius { get; set; }
        private double first_side { get; set; }
        private double second_side { get; set; }
        private double third_side { get; set; }


        public Area(double radius)
        {
            this.radius = radius;
        }

        public Area(double first,double second,double third)
        { 
            //проверка существует ли такой треугольник
            if ((first + second > third) && (second + third > first) && (first + third > second))
            {
                first_side = first;
                second_side = second;
                third_side = third;
                
            }
            else Console.WriteLine("Треугольника с такими сторонами не существует");
        }


        public double area_circle()
        {
            return 3.14 * Math.Pow(radius,2);
        }


        public double area_triangle()
        {
            //Является ли треугольник прямоугольным и вычисление площади по половине произведения катетов
            if (Math.Pow(first_side, 2) == Math.Pow(second_side, 2) + Math.Pow(third_side, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
                return 0.5 * second_side * third_side;
            }
            else if (Math.Pow(second_side, 2) == Math.Pow(first_side, 2) + Math.Pow(third_side, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
                return 0.5 * first_side * third_side;
            }
            else if (Math.Pow(third_side, 2) == Math.Pow(second_side, 2) + Math.Pow(first_side, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
                return 0.5 * second_side * first_side;
            }
            else             //Если треугольник обыкновенный
            {
                double p = (first_side + second_side + third_side) / 2; //Полупериметр
                return Math.Sqrt(p*(p-first_side)*(p-second_side)*(p-third_side));  //Формула Герона
            }
        }

        public double area_noname()
        {
            if (radius==0)
            {
                return area_triangle();
            }
            else
            {
                return area_circle();
            }
        }


    }
}
