using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lb32.Models
{
    abstract class Figure
    {
        protected  double Length;
        protected double Space;
        protected double R;
        protected Point p1;
        public abstract void Zoom(double z);
        public abstract void Move(int X1, int Y1);
        public abstract override string ToString();
    }
}
