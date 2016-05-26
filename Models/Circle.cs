using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lb32.Models
{
    class Circle:Figure
    {
        public Circle(Point p1 , int R)
        {
            this.p1 = p1;
            this.R = R;
        }
        public new virtual double Space
        {
            get
            {
                return Math.PI * R * R;
            }
            set
            {
                R = Math.Sqrt(value / Math.PI);
            }
        }
        public new virtual double Length
        {
            get
            {
                return 2 * Math.PI * R;
            }
            set
            {
                R = value / (2 * Math.PI);
            }
        }
        public override void Zoom(double Z)
        {
            R = R * Z;
            Console.WriteLine(R);
        }
        public override void Move(int X1, int Y1)
        {
            p1.X = p1.X + X1;
            p1.Y = p1.Y + Y1;
            Console.WriteLine($"{p1.X},{p1.Y}");
        }
        public override string ToString()
        {
            return $"Координаты точки:{p1}, Площадь : {Space}, Длина:{Length}, Радиус:{R}";
        }
    }
}
