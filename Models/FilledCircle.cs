using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lb32.Models
{
    class FilledCircle:Circle
    {
        private Color c1;
        public FilledCircle(Point p1, int R, Color c): base(p1, R)
        {
            this.p1 = p1;
            this.R = R;
            c1 = c;
        }
        public override string ToString()
        {
            return base.ToString()+$" Цвет:{c1.Name}";
        }
    }
}
