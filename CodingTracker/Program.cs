using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
            List<string> history = new List<string>();
            Random rn= new Random();
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
                            Console.Clear();
                            running= false;
                            Console.WriteLine("add");
                            OperationMode("a");
                            break;
                        case "s":
                            Console.Clear();
                            running= false;
                            Console.WriteLine("sub");
                            break;
                        case "m":
                            Console.Clear();
                            running= false;
                            Console.WriteLine("mul");
                            break;
                        case "d":
                            Console.Clear();
                            running= false;
                            Console.WriteLine("div");

                            break;
                    }
                else
                {
                    {
                        Console.Clear();
                        Console.WriteLine("invalid Choice");
                        Console.WriteLine();
                    }
                }
            }
            public void OperationMode(string oper)
            {
                int firstNum = rn.Next(0, 100);
                int secondNum = rn.Next(0, 100);
                int sum = firstNum+ secondNum;
                int userAnswer;
                switch (oper)
                {
                    case "a":
                        Check(firstNum, secondNum, sum , "+");
                        break;
                }
                
            }

            public void Check(int firstNum, int secondNum, int sum, string oper)
            {
                string currentQuestion = $"{ firstNum } {oper} { secondNum} = ? ";
                int userAnswer;
                bool answer;
                Console.WriteLine(currentQuestion);
                int.TryParse(Console.ReadLine(), out userAnswer);
                if (userAnswer != sum)
                {
                    answer = false;
                    Console.WriteLine("Wrong answer");
                }
                else
                {
                    answer = true;
                    Console.WriteLine("Correct");

                }
                currentQuestion += (userAnswer.ToString() +" "+ answer.ToString());
                history.Add(currentQuestion);
                running= true;
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
