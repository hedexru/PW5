namespace PW5_4
{
    interface IShape
    {
        void Draw(int size);
    }

    class VerticalLine : IShape
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("|");
            }
        }
    }

    class HorizontalLine : IShape
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }

    class Square : IShape
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[] { new VerticalLine(), new HorizontalLine(), new Square() };
            int size = 6;
            foreach (IShape shape in shapes)
            {
                Console.Write("Нарисовали ");
                Console.Write(shape.GetType().Name);
                Console.Write(" размером ");
                Console.WriteLine(size);
                shape.Draw(size);
                Console.WriteLine();
            }
        }
    }

}