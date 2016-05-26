using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lb32.Models
{
    class Dot:Figure
    {
        public Dot(Point p1)
        {
            this.p1 = p1;
        }
        public override void Move(int X1, int Y1)
        {
            p1.X = p1.X + X1;
            p1.Y = p1.Y + Y1;
            Console.WriteLine($"{p1.X},{p1.Y}");
        }
        public override void Zoom(double z)
        {
            Console.WriteLine("Нельзя увеличить");
        }
        public override string ToString()
        {
            return $"Координаты точки:{p1}";
        }

    }

}
