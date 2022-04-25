using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    class Helper
    {
        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();

            if (input.Length == 0)
            {
                Console.WriteLine("You must enter something. Let's try again.");
                return (GetUserInput(prompt));
            }

            input = input.Substring(0, 1).ToUpper() + input.Substring(1); // To capitalize first letter.
            return input;
        }

        public bool RunAgain()
        {
            Console.WriteLine("Would you like to run the program again? y/n");
            string answer = Console.ReadLine().ToLower().Trim();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that. Let's try again.");
                return RunAgain();
            }
        }
    }
}
