namespace statistics_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberCruncher test = new NumberCruncher();

            test.addNumber(10.5);
            test.addNumber(13.8);
            test.addNumber(9);

            test.displayData();
        }
    }
}
