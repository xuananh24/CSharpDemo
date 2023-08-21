using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing rectangle");
        }
    }
}
