using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //има една грешка в последния пример на последния ред, дадени са само заглавията на филмите
    //а не както ппц трябва да излизат филмите
    class Cinema
    {
        private string name;
        private List<Movie> movies = new List<Movie>();

        public Cinema(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public List<Movie> Movies
        {
            get { return movies; }
        }

        public void AddMovie(string title, double rating)
        {
            Movies.Add(new Movie(title, rating));
        }

        public double AverageRating()
        {
            double avrg = 0;
            foreach (var movie in movies)
            {
                avrg += movie.Rating;
            }
            avrg /= movies.Count;
            return avrg;
        }

        public List<Movie> SortByTitle()
        {
            movies = movies.OrderBy(x => x.Title).ToList();
            return movies;
        }

        public List<Movie> SortByRating()
        {
            movies = movies.OrderByDescending(x => x.Rating).ToList();
            return movies;
        }

        public string[] ProvideInformationAboutAllMovies()
        {
            string[] arr = new string[movies.Count];
            for (int i = 0; i < movies.Count; i++)
            {
                arr[i] = movies[i].ToString();
            }
            return arr;
        }

        public bool CheckMovieIsInCinema(string title)
        {
            foreach (var movie in movies)
            {
                if (movie.Title == title) return true;
            }
            return false;
        }

        internal List<string> GetMoviesByRating(double rating)
        {
            return movies.Where(x => x.Rating > rating).Select(x => x.ToString()).ToList();
        }
    }
}
