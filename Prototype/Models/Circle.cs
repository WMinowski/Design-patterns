using Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models
{
    class Circle : IFigure
    {
        int radius;

        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", radius);
        }
    }
}
