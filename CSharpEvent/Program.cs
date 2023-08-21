namespace CSharpEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subcriber subcriber = new Subcriber();
                
            subcriber.Sub(publisher);

            MyEventArgs myEventArgs = new MyEventArgs("data");
            publisher.OnClick(myEventArgs);

        }
    }

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(string data)
        {
            this.data = data;
        }
        private string data;

        public string Data
        {
            get { return data; }
        }
    }


    class Publisher
    {
        public delegate void ClickEventHandler(object sender, MyEventArgs e);

        public event ClickEventHandler Click;

        public void OnClick(MyEventArgs e)
        {
            Click?.Invoke(this, e);
        }
    }

    class Subcriber
    {
        public void Sub(Publisher publisher)
        {
            publisher.Click += ReceiveFromPublisher;
        }

        public void ReceiveFromPublisher(object sender, MyEventArgs e)
        {
            Console.WriteLine("Subcriber: " + e.Data);
        }
    }
}