namespace CSharpBasic

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pass by reference
            People people1 = new People();
            people1.Name = "People 1";
            System.Console.WriteLine("Name before: " + people1.Name);
            ChangeName(people1);
            System.Console.WriteLine("Name after: " + people1.Name);

            //Pass by value
            int num = 10;
            System.Console.WriteLine("num before: " + num);
            ChangeValue(num);
            System.Console.WriteLine("num after: " + num);

        }
        static void ChangeName(People people)
        {
            people.Name = "Test";
        }
        static void ChangeValue(int num)
        {
            num = 100;
        }
    }

    class People
    {
        private string? name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}