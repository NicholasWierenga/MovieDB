namespace MovieDB
{
    public class MovieLibrary
    {
        
        public static void Main()
        {
            Movie frozen = new Movie("Frozen", MovieType.Animated);
            Movie up = new Movie("Up", MovieType.Animated);
            Movie wallE = new Movie("Wall-E", MovieType.Animated);
            Movie starTrek = new Movie("Star Wars", MovieType.Scifi);
            Movie starWars = new Movie("Star Trek", MovieType.Scifi);
            Movie spaceOdyssey = new Movie("2001: A Space Odyssey", MovieType.Scifi);
            Movie pvtRyan = new Movie("Saving Private Ryan", MovieType.Drama);
            Movie noCountry = new Movie("No Country For Old Men", MovieType.Drama);
            Movie Saw = new Movie("Saw", MovieType.Horror);
            Movie Insidious = new Movie("Insidious", MovieType.Horror);

            Helper helper = new Helper();

            List<Movie> movList = new List<Movie>{ frozen, up, wallE, starTrek, starWars, spaceOdyssey, pvtRyan,
                noCountry, Saw, Insidious };
            List<string> genreList = new List<string> { };

            bool runAgain = true;
            int i;

            while (runAgain)
            {
                Console.WriteLine("Welcome to the movie database. Please enter one of the following genres or their number.");

                i = 0;
                foreach (string str in Enum.GetNames(typeof(MovieType)))
                {
                    Console.WriteLine(str + " with number " + i + ".");
                    i++;
                }

                string input = helper.GetUserInput("What genre do you want to search for? Type all for all movies.");
                
                if (input == "All")
                {
                    foreach (Movie movie in movList)
                    {
                        movie.PrintInfoAll();
                    }
                }
                else
                try
                {
                    MovieType movGenre = (MovieType)Enum.Parse(typeof(MovieType), input);

                    foreach (Movie movie in movList)
                    {
                        if (movie.Genre == movGenre)
                        {
                            genreList.Add(movie.Title);
                        }
                    }

                    genreList.Sort();
                    foreach (string str in genreList)
                    {
                        Console.WriteLine(str);
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a correct genre or number.");
                    Console.WriteLine("Let's try again");

                    continue;
                }

                if (int.TryParse(input, out int j) && j >= Enum.GetValues(typeof(MovieType)).Length || j < 0)
                {
                    Console.WriteLine("You must input the right number to search by number. Let's try again.");
                    continue;
                }

                runAgain = helper.RunAgain();
            }
        }
    }
}