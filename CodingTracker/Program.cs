using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodingTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To the Math Game , Where you choose type of Game and answer questions accordingly");
            var game = new Runner();
            game.Run();
        }
        public class Runner
        {
            private bool running = true;
            private string userChoice;
            public void Run()
            {
                while (running == true)
                {
                    Console.WriteLine("Choose your type of game \n" +
                        "A - Addition\n" +
                        "S - Subtraction\n" +
                        "M - Multiplication\n" +
                        "D - Division");
                    userPickChoice();
                }
            }
            public void userPickChoice()
            {
                userChoice = Console.ReadLine().ToLower();
                if (userChoice == "a" || userChoice == "s" || userChoice == "m" || userChoice == "d")
                    switch (userChoice)
                    {
                        case "a":
                            Console.WriteLine("add");
                            break;
                        case "s":
                            Console.WriteLine("sub");
                            break;
                        case "m":
                            Console.WriteLine("mul");
                            break;
                        case "d":
                            Console.WriteLine("div");

                            break;
                    }
                else
                {
                    {
                        Console.WriteLine(userChoice == "a");
                        Console.Clear();
                        Console.WriteLine("invalid Choice");
                        Console.WriteLine();
                    }
                }
            }

        }
        public class Addition
        {

        }
        public class Subtraction
        {

        }
        public class Multiplication
        {

        }
        public class Divison
        {

        }
    }
}
