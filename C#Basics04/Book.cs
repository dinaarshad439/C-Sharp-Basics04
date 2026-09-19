using System;
using System.Collections.Generic;
using System.Text;

namespace C_Basics04
{
    /// <summary>
    /// Represents a book with its title, genre, and stock information.
    /// </summary>
    internal class Book
    {

        private string Password = "Secret";

        internal int copiesInStock = 5;

        public string? Title;

        public Genre Genre { set; get; } = Genre.Science;


    }
}
