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

            //Loop program until user wants to quit
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Enter a number between 1 and 100:");

                int inputNum = GetInput();


                

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


                //Ask if user wants to continue
                Console.WriteLine("Continue? (y/n):");

                string cont = Console.ReadLine();

                //Verify input
                while (cont != "y" && cont != "Y" && cont != "n" && cont != "N")
                {
                    Console.WriteLine("I don't understand what you said, " + name + ". Please enter y/n:");
                    cont = Console.ReadLine();
                }

                //Quit program
                if (cont == "n" || cont == "N")
                {
                    Console.WriteLine("Bye, " + name + "!");
                    runProgram = false;
                }

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

        public static int GetInput()
        {
            int inputNum = -1;

            //Is input an integer?
            try
            {
                inputNum = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Input was not an integer! Please type a whole number between 1 and 100:");
                inputNum = GetInput();
            }

            //Is input between 1 and 100?
            if (inputNum < 1 || inputNum > 100)
            {
                Console.WriteLine("Input must be a whole number between 1 and 100! Try again:");
                inputNum = GetInput();
            }

            return inputNum;
        }


        public static Boolean Continue()
        {
            Console.WriteLine("Continue? y/n: ");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

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
