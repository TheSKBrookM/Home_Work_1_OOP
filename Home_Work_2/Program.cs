namespace Home_Work_2
{
    internal class Program
    {
        static void Main()
        {
            Title title = new Title();
            title.Name = "The Lord of the rings";

            Body text = new Body();
            text.Text = "Part 1";

            Author author = new Author();
            author.Name = "John Ronald Reuel Tolkien";

            Book book = new Book(title, text, author);
            book.Show();
        
            Console.ReadLine();
        }
    }
}