﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static ArrayList movieList = new ArrayList()
               {new Movie("American Beauty","drama" ),
                new Movie("Donnie Darko", "drama"),
                new Movie("Primer", "scifi"),
                new Movie("Upside Down", "scifi"),
                new Movie("Blade Runner", "scifi"),
                new Movie("House of 1000 Corpses", "horror"),
                new Movie("The Hills have Eyes", "horror"),
                new Movie("Spirited Away", "animated"),
                new Movie("Howl's Moving Castle", "animated"),
                new Movie("My Neighbor Totoro", "animated")};
        static void Main(string[] args)
        {
            MovieRunner();
           
        }

        static void MovieRunner()
        {
            Console.Write("Enter a movie genre: " );
            string input = Console.ReadLine().ToLower();
            if (Validation.areLettersValid(input))
            {
                bool flag = false;
                movieList.Sort();
                foreach (Movie movie in movieList)
                {
                    if (input == movie.GetGenre())
                    {
                        flag = true;
                        Console.WriteLine(movie.GetTitle());
                    }
                   
                }
                if (flag == false)
                {
                    Console.WriteLine("We dont have that");
                   
                }
            }
            else
            {
                Console.WriteLine("Please use your words");
                MovieRunner();
            }
            looping();
        }

        static void looping()
        {
            Console.WriteLine("Continue? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {
                Console.Clear();
                MovieRunner();

            }
            else if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine("Bye");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("That was pure nonsense, grow up.");
                looping();
            }

        }


    }
}
