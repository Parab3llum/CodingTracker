﻿using System;
using System.Collections.Generic;
using System.Threading;

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
            //Timer t = new Timer(TimerCountDown, null ,0, 1000);


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
                        "H - Show History\n"); 
                    //+
                    //    "L - Choose Difficulty level");
                    userPickChoice();
                }
            }
            public void userPickChoice()
            {

                userChoice = Console.ReadLine().ToLower();
                switch (userChoice)
                {
                    case "a":
                        DifficultyLevel(userChoice);
                        break;
                    case "s":
                        DifficultyLevel(userChoice);
                        break;
                    case "m":
                        DifficultyLevel(userChoice);
                        break;
                    case "d":
                        DifficultyLevel(userChoice);
                        break;
                    case "h":
                        ShowHistory(userChoice);
                        break;
                    
                    default:
                        ErrMessage();
                        break;
                }
            }

            private void DifficultyLevel(string userChoice)
            {
                int firstNumber;
                int secondNumber;
                Console.WriteLine("Enter difficulty level:\n" +
                    "E - Easy\n" +
                    "M - Medium\n" +
                    "H - Hard\n");
                string level = Console.ReadLine();
                switch (level)
                {
                    case "e":
                        firstNumber = rn.Next(0, 9);
                        secondNumber = rn.Next(0, 9);
                        OperationMode(userChoice,level, firstNumber, secondNumber);
                        break;
                    case "m":
                        firstNumber = rn.Next(0, 100);
                        secondNumber = rn.Next(0, 100);
                        OperationMode(userChoice, level, firstNumber, secondNumber);
                        break;
                    case "d":
                        firstNumber = rn.Next(0, 100);
                        secondNumber = rn.Next(0, 100);
                        OperationMode(userChoice, level, firstNumber, secondNumber);
                        break;
                    default:
                        ErrMessage();
                        break;
                }
            }

            private void ShowHistory(string choice)
            {
                if (userChoice == "h")
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

            }

            private static void ErrMessage()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid Choice");
                Console.WriteLine();
            }

            public void OperationMode(string oper, string level, int numOne, int numTwo)
            {
                Console.Clear();
                //int firstNum = rn.Next(0, 100);
                //int secondNum = rn.Next(0, 100);
                int sum = 0;
                switch (oper)
                {
                    case "a":
                        Check(numOne, numTwo, sum, "+");
                        break;
                    case "s":
                        Check(numOne, numTwo, sum, "-");
                        break;
                    case "m":
                        Check(numOne, numTwo, sum, "*");
                        break;
                    case "d":
                        Check(numOne, numTwo, sum, "/");
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

            private static void TimerCountDown(object state)
            {
                Console.WriteLine();
            }

        }
    }
}
