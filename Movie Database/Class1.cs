using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    public enum MovieType // I wanted to try enum instead of string.
    {
        Horror,
        Drama,
        Animated,
        Scifi
    }

    
    class Movie
    {
        public string Title { get; set; }
        public MovieType Genre { get; set; }

        public Movie(string Title, MovieType Genre)
        {
            this.Title = Title;
            this.Genre = Genre;
        }
        public void PrintInfoAll()
        {
            Console.WriteLine(Title + " is a " + Genre + " film.");
        }
        public void PrintInfo()
        {
            Console.WriteLine(Title);
        }
        public static bool RunAgain()
        {
            Console.WriteLine("Would you like to run again?");
            Console.ReadLine();

            return true;
        }
    }
}
