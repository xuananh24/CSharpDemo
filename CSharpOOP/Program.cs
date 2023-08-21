namespace CSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Rectangle();

            shape1.Draw();
            shape2.Draw();
        }

    }
}