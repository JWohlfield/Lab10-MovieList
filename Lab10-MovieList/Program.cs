using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab10_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Movie m = new Movie("","");
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("The Godfather", "drama"));
            movies.Add(new Movie("The Texas Chainsaw Massacre", "horror"));
            movies.Add(new Movie("The Shawshank Redemption", "drama"));
            movies.Add(new Movie("Roger Rabbit", "animated"));
            movies.Add(new Movie("Star Wars", "scifi"));
            movies.Add(new Movie("Se7en", "drama"));
            movies.Add(new Movie("Cinderella", "animated"));
            movies.Add(new Movie("Iron Man", "scifi"));
            movies.Add(new Movie("Halloween", "horror"));
            movies.Add(new Movie("Frozen", "animated"));
            movies.Add(new Movie("JAWS", "horror"));
            movies.Add(new Movie("Jurassic Park", "scifi"));
            //  Create a copy of the movies list sorted by title
            List<Movie> SortedList = movies.OrderBy(sm => sm.Title).ToList();

            Console.WriteLine("Welcome to the totally amazing Movie List app");
            
            while(true)
            {
                string pick = "";
                Console.WriteLine("Please select");
                Console.WriteLine("1) animated\n2) drama\n3) horror\n4) scifi");
                string input = Console.ReadLine().Trim();
                if (input == "1" || input == "animated")
                {
                    pick = "animated";
                }
                else if (input == "2" || input == "drama")
                {
                    pick = "drama";
                }
                else if (input == "3" || input == "horror")
                {
                    pick = "horror";
                }
                else if (input == "4" || input == "scifi")
                {
                    pick = "scifi";
                }
                else
                {
                    Console.WriteLine("Let's try again");
                    continue;
                }

                
                foreach (var m in SortedList)
                {
                    if(m.Category == pick)
                    {
                        m.PrintMovies();
                    }
                }

                if (!GoAgain())
                {
                    break;
                }
            }
            Console.WriteLine("Goodbye!");
        }

        public static bool GoAgain()
        {
            while (true)
            {
                Console.Write("\nContinue? y/n ");
                string input = Console.ReadLine();
                
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Let's try again");
                    continue;
                }
                else if(input.ToLower() == "y")
                {
                    return true;
                }

                return false;
            }
        }
    }
}
