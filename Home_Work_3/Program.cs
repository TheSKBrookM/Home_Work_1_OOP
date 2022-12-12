namespace Home_Work_3
{
    internal class Program
    {
        static void Main()
        {

            Figure figure = new Figure(new Point(1, 1, "A"), new Point(2, 3, "B"), new Point(0, 2, "C"));

            Console.WriteLine(figure.Type);

            figure.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}