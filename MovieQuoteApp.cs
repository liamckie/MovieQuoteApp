using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieQuoteApp
{
    class MovieQuoteApp
    {
        private string QuotesFilePath = "MovieQuote.txt";
        List<MovieQuote> quotes = new List<MovieQuote>();


        public void Run()
        {
            Console.Title = "Movie Quote of the Day";

            bool running = true;

            while (running) {
                Console.WriteLine("Please choose an option : " +
                                  "\n1. Display all quotes" +
                                  "\n2. Display random quote" +
                                  "\n3. Exit");
                Console.Write(" >>> ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        DisplayAllQuotes();
                        Console.WriteLine("\n\n");
                        break;
                    case 2:
                        Console.Clear();
                        DisplayOneRandomQuote();
                        Console.WriteLine("\n\n");
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        running = false;
                        break;
                    default:
                        break;
                }
            }
            
            WaitForKey();
        }

        public void DisplayAllQuotes()
        {
            string[] lines = File.ReadAllLines(QuotesFilePath);

            for (int i = 0; i < lines.Length; i += 3)
            {
                string txt = lines[i];
                string info = lines[i + 1];
                string[] infoParts = info.Split(", ");
                string name = infoParts[0];
                int year = Convert.ToInt32(infoParts[1]);
                MovieQuote quote = new MovieQuote(txt, name, year);
                quotes.Add(quote);
                quote.Display();
            }
        }

        public void DisplayOneRandomQuote()
        {
            List<MovieQuote> quotesList = new List<MovieQuote>();

            // To display one quote at a time
            Random randomNumber = new Random();
            MovieQuote oneQuote = quotes[randomNumber.Next(quotes.Count)];
            quotesList.Add(oneQuote);
            oneQuote.Display();
        }

        private void WaitForKey()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey(true);
        }
    }
}
