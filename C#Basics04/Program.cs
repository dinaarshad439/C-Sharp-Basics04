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

            //Console.WriteLine("Enter book title:");
            //book.Title = Console.ReadLine();
            //Console.WriteLine($"Book Title : {book.Title}");

            #endregion

            #region (Q4) Using Enum with a Property

            //Console.WriteLine($"Book Genre: {book.Genre}");

            #endregion

            #region (Q5) Casting Enum Values to int

            //Genre Genre1 = Genre.Fiction;
            //int Value1 = (int)Genre1;
            //Console.WriteLine($"{Genre1} : {Value1}");

            //Genre Genre2 = Genre.NonFiction;
            //int Value2 = (int)Genre2;
            //Console.WriteLine($"{Genre2} : {Value2}");

            //Genre Genre3 = Genre.Science;
            //int Value3 = (int)Genre3;
            //Console.WriteLine($"{Genre3} : {Value3}");

            #endregion

            #region (Q6) Convert an integer value to its corresponding Genre enum value

            //bool flag ;
            //int GenreNumber;
            //do
            //{
            //    Console.WriteLine("Enter Genre number: ");
            //    flag = int.TryParse(Console.ReadLine(), out GenreNumber);

            //}while (!flag || GenreNumber < 0);

            //if (Enum.IsDefined(typeof(Genre), GenreNumber)) 
            //{ 
            //  Genre Value = (Genre)GenreNumber;
            //  Console.WriteLine($"Book Genre : {Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}

            #endregion

            #region (Q7) Converting Enum to String

            Genre genre = Genre.Fiction;
            string Text = genre.ToString();
            Console.WriteLine($"Book Genre after converting to string: {Text}");

            #endregion






        }
    }
}
