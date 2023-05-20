using System;
using System.Collections.Generic;

namespace CodingTracker
{
    internal partial class Program
    {
        public class Runner
        {
            private bool running = true;
            private string userChoice;
            List<string> history = new List<string>();
            Random rn = new Random();
            public void Run()
            {
                while (running == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Choose your type of game \n" +
                        "A - Addition\n" +
                        "S - Subtraction\n" +
                        "M - Multiplication\n" +
                        "D - Division\n" +
                        "H - Show History");
                    userPickChoice();
                }
            }
            public void userPickChoice()
            {
                userChoice = Console.ReadLine().ToLower();
                if (userChoice == "a" || userChoice == "s" || userChoice == "m" || userChoice == "d")
                {
                    OperationMode(userChoice);
                }
                else if (userChoice == "h")
                {
                    Console.Clear();
                    Console.WriteLine("Recorded answers :");
                    Console.WriteLine("-----------------");
                    if (history.Count == 0)
                    {
                        Console.WriteLine("no recorded answers");
                        Console.WriteLine();

                    }
                    foreach (var item in history)
                    {
                        Console.WriteLine(item);
                    }
                }

                else
                {
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid Choice");
                        Console.WriteLine();
                    }
                }
            }
            public void OperationMode(string oper)
            {
                Console.Clear();
                int firstNum = rn.Next(0, 100);
                int secondNum = rn.Next(0, 100);
                int sum = 0;

                int userAnswer;
                switch (oper)
                {
                    case "a":
                        Check(firstNum, secondNum, sum, "+");
                        break;
                    case "s":
                        Check(firstNum, secondNum, sum, "-");
                        break;
                    case "m":
                        Check(firstNum, secondNum, sum, "*");
                        break;
                    case "d":
                        Check(firstNum, secondNum, sum, "/");
                        break;
                }


            }

            public void Check(int firstNum, int secondNum, int sum, string oper)
            {
                string currentQuestion = $"{firstNum} {oper} {secondNum} = ? ";
                int userAnswer;
                bool answer;
                switch (oper)
                {
                    case "+":
                        sum = firstNum + secondNum;
                        break;
                    case "-":
                        sum = firstNum - secondNum;
                        break;
                    case "*":
                        sum = firstNum * secondNum;
                        break;
                    case "/":
                        sum = firstNum / secondNum;
                        break;

                    default:
                        break;
                }
                Console.WriteLine(currentQuestion);
                int.TryParse(Console.ReadLine(), out userAnswer);
                if (userAnswer != sum)
                {
                    answer = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong answer , the correct answer is {sum}");
                }
                else
                {
                    answer = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");

                }
                currentQuestion += (userAnswer.ToString() + " " + answer.ToString());
                history.Add(currentQuestion);
                running = true;
            }
        }
    }
}
