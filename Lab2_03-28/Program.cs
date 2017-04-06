using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_03_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?:");
            string name = Console.ReadLine();

            Console.WriteLine("Greetings, " + name + "!");

            //Keep track of user inputs and results for later
            List<int> userEntries = new List<int>();
            List<string> results = new List<string>();

            //Loop program until user wants to quit
            bool runProgram = true;
            while (runProgram)
            {
                int inputNum = -1;
                bool isValidInput = false;

                //Get and validate input
                do
                {
                    Console.WriteLine("\nEnter a number between 1 and 100, or type 'print' to list results so far:");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput.Equals("print"))
                    {
                        PrintAll(userEntries, results);
                    }
                    else
                    {
                        bool isInteger = false;
                        try
                        {
                            inputNum = int.Parse(userInput);
                            isInteger = true;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Input was not an integer! Please type a whole number between 1 and 100.");
                            isInteger = false;
                        }

                        //Is input between 1 and 100?
                        if (isInteger == true)
                        {
                            if (inputNum < 1 || inputNum > 100)
                            {
                                Console.WriteLine("Input must be a whole number between 1 and 100! Try again.");
                            }
                            else
                            {
                                isValidInput = true;
                            }
                        }

                    }
                } while (isValidInput == false);


                bool isEven = CheckIfEven(inputNum);

                //Output defaults to error message
                string output = "Invalid input.";

                //Is inputNum odd?
                if (isEven == false)
                {
                    output = inputNum + " and Odd.";
                }
                //Is inputNum even and between 2 and 25?
                else if (isEven == true && inputNum >= 2 && inputNum <= 25)
                {
                    output = "Even and less than 25.";
                }
                //Is inputNum even and between 26 and 60?
                else if (isEven == true && inputNum >= 26 && inputNum <= 60)
                {
                    output = "Even.";
                }
                //Is inputNum even and over 60?
                else if (isEven == true && inputNum > 60)
                {
                    output = inputNum + " and Even.";
                }
                //Is inputNum odd and over 60?
                else if (isEven == false && inputNum > 60)
                {
                    output = inputNum + " and Odd.";
                }
                //Invalid input
                else
                {
                    output = "Invalid input.";
                }

                //Display final output
                Console.WriteLine("Output: " + output);

                userEntries.Add(inputNum);
                results.Add(output);

                //Ask if user wants to continue
                Console.WriteLine("Continue? (y/n):");

                runProgram = Continue();
            }
            
        }

        public static bool CheckIfEven(int inputNum)
        {
            if (inputNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintAll(List<int> userEntries, List<string> results)
        {
            Console.WriteLine("\nHere are the results so far:");
            Console.WriteLine("==========================================");
            for (int i=0; i < userEntries.Count; i++)
            {
                Console.WriteLine("Round " + (i + 1) + " | User entry: " + userEntries[i] + " Result: " + results[i]);
            }
        }

        public static Boolean Continue()
        {
            string input = Console.ReadLine().ToLower();
            Boolean run = false;

            if(input == "n")
            {
                Console.WriteLine("Goodbye.");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}
