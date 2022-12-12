namespace Home_Work_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Rectangle side 1 : ");
            double side1 = Double.Parse(Console.ReadLine());

            Console.Write("Rectangle side 2 : ");
            double side2 = Double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Area: {rectangle.Area}");

            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

            Console.ReadKey();
        }
    }
}