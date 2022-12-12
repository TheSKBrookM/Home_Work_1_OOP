namespace Home_Work_4
{
    internal class Program
    {
        static void Main()
        {
            Adress adress = new Adress();

            adress.Country = "Ukraine";
            adress.City = "Kyiv";
            adress.Street = "Bankova";
            adress.House = "5a";
            adress.Apartment = "1";
            adress.Index = "20040";

            Console.WriteLine($"{adress.Country}\n{adress.City}\n{adress.Street}\n{adress.House}\n{adress.Apartment}\n{adress.Index}");

            Console.ReadKey();

        }
    }
}