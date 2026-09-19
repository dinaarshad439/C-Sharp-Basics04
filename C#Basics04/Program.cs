namespace C_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region (Q1) Accessing a Private Field from Main

            Book book = new Book();
            Console.WriteLine(book.Password);

            /*
             * It will result in a compilation error. 
             * As Variable Password is private so its accessible only inside the class.
             */

            #endregion

            
        }
    }
}
