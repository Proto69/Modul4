using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Movie
    {
        private string title;
        private double rating;

        public Movie(string title, double rating)
        {
            this.title = title;
            this.rating = rating;
        }

        public string Title
        {
            get { return title; }
        }

        public double Rating
        {
            get { return rating; }
        }

        public override string ToString()
        {
            return $"Movie {title} is with {rating:F1} rating.";
        }

    }
}
