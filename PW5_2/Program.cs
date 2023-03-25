namespace PW5_2
{
    interface IHello
    {
        void SayHello();
    }

    class EnglishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class UkrainianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привiт");
        }
    }

    class BellorussianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Прывiтанне");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IHello> hellos = new List<IHello>();
            hellos.Add(new EnglishHello());
            hellos.Add(new UkrainianHello());
            hellos.Add(new BellorussianHello());

            foreach (IHello hello in hellos)
            {
                hello.SayHello();
            }
        }
    }
}