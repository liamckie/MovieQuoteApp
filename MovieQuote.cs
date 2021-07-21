using System;
using System.Collections.Generic;
using System.Text;

namespace MovieQuoteApp
{
    class MovieQuote
    {
        private string Txt;
        private string Author;
        private int Year;

        public MovieQuote(string txt, string author, int year)
        {
            Txt = txt;
            Author = author;
            Year = year;
        }

        public void Display()
        {
            Console.WriteLine("+----------------------------------------+" +
                              $"\n\"{Txt}\"" +
                              $"\n - {Author}, {Year}\n" +
                              "+----------------------------------------+");
        }
    }
}
