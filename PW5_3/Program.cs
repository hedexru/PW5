namespace PW5_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }

    class DigitFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string result = "";
            foreach (char c in textLine)
            {
                if (!Char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }

    class LetterFilter : IFilter
    {
        public string Execute(string textLine)
        {
            string result = "";
            foreach (char c in textLine)
            {
                if (!Char.IsLetter(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFilter digitFilter = new DigitFilter();
            IFilter letterFilter = new LetterFilter();

            string textLine = "I th1nk t3xt w1th d1g1ts n0w 1s n0t actual";
            string filteredText = digitFilter.Execute(textLine);
            Console.WriteLine($"digits filtred: {filteredText}");

            filteredText = letterFilter.Execute(textLine);
            Console.WriteLine($"chars filtred: {filteredText}");
        }
    }

}