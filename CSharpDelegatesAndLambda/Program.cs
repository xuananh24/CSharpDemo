using static CSharpDelegatesAndLambda.Program;

namespace CSharpDelegatesAndLambda
{
    internal class Program
    {
        public delegate double MathOperation(double a, double b);
        static void Main(string[] args)
        {
            //Delegate and Lambda
            MathOperation add = (a, b) => a + b;
            double resultAdd = add(8, 6);
            Console.WriteLine("resultAdd: " + resultAdd);

            //Passing Delegate as a Parameter
            Calculator calculator = new Calculator();
            MathOperation mathOperation = Subtract;
            double resultSubtract = calculator.PerformOperation(mathOperation, 8, 6);
            Console.WriteLine("resultSubtract: " + resultSubtract);

        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }
    }

    class Calculator
    {
        public double PerformOperation(MathOperation mathOperation, double a, double b)
        {
            return mathOperation(a, b);
        }
    }
}