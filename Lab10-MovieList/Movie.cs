using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_MovieList
{
    class Movie
    {
        private string _title;
        private string _category;

        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }

        public void PrintMovies()
        {
            Console.WriteLine($"Title: {Title} - ({Category})");
        }
    }
}
