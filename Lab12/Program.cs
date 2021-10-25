using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle.Radius = 1;//Здаем значение переменной непосредственно обращаясь к ней при инициализации объекта класса static Circle
            Circle.x0 = 0;//Задаем координаты центра окружности
            Circle.y0 = 0;
            Circle.x = 0;//Задаем координаты точки на плоскости 
            Circle.y = 1;

            Console.WriteLine("Длина окружности радиусом 'Radius' равна:");
            Circle.GetCircleLength();
            Console.WriteLine("Площадь окружности радиусом 'Radius' равна:");
            Circle.GetCircleArea();
            Console.WriteLine();
            Circle.CheckPointInCircle();//Проверяем принадлежность точки окружности
            Console.ReadKey();
        }
    }
    public static class Circle
    {
        static int radius;
        public static int x0 { get; set; }
        public static int y0 { get; set; }
        public static int x { get; set; }
        public static int y { get; set; }

        public static int Radius// Проверка длины R на положительность и условие !=0.
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Введите положительное число большее чем 0");
                }
                else
                {
                    radius = value;
                }
            }
            get
            {
                return radius;
            }
        }
        static Circle()
        {
            radius = Radius;
        }

        public static void GetCircleLength()
        {
            Console.WriteLine(2*radius* Math.PI);
        }
        public static void GetCircleArea()
        {
            Console.WriteLine(radius * radius * Math.PI);
        }
        public static void CheckPointInCircle()
        {
            double a = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y- y0, 2));
            if (a<=radius)
            {
                Console.WriteLine("Точка принадлежит окружности");
            }
            else
            {
                Console.WriteLine("Точка находится вне окружности");
            }
        }
    }
}
