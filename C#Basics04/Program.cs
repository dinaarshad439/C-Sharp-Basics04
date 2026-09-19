namespace C_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region (Q1) Accessing a Private Field from Main

            Book book = new Book();
            // Console.WriteLine(book.Password);

            /*
             * It will result in a compilation error. 
             * As Variable Password is private so its accessible only inside the class.
             */

            #endregion

            #region (Q2) Accessing a Internal Field from Main


            // Console.WriteLine(book.copiesInStock);

            /*
             * Yes, It compiled.
             * As Variable copies in stock is internal so its accessible only within the same assembly.
             */

            #endregion

            #region (Q3) Accessing a Public Field from Main

            Console.WriteLine("Enter book title:");
            book.Title = Console.ReadLine();
            Console.WriteLine($"Book Title : {book.Title}");

            #endregion




        }
    }
}
