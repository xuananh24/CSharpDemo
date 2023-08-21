using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; } set {  radius = value; }
        }

        public override void Draw()
        {
            System.Console.WriteLine("Drawing circle");
        }
    }
}
