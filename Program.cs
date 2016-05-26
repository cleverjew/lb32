using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lb32.Models;
using System.Drawing;

namespace lb32
{
    class Program
    {
        static void Main(string[] args)
        {
            FilledCircle c = new FilledCircle(new Point(0, 0), 5, Color.Azure);
            Console.WriteLine(c);
            Circle c1 = new Circle(new Point(1, 1), 4);
            Console.WriteLine(c1);
            c1.Move(2,3);
            Console.WriteLine(c1);
        }
    }
}
