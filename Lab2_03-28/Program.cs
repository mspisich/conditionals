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
                Console.WriteLine("Please input an integer between 1 and 100:");
                int inputNum = int.Parse(Console.ReadLine());

                //Verify input
                while (inputNum < 1 || inputNum > 100)
                {
                    Console.WriteLine("I'm sorry " + name + ", what you entered is invalid. Please enter an integer between 1 and 100:");
                    inputNum = int.Parse(Console.ReadLine());
                }

                //Is inputNum odd?
                if (inputNum % 2 != 0)
                {
                    Console.WriteLine(inputNum + " Odd.");
                }
                //Is inputNum even and between 2 and 25?
                else if (inputNum % 2 == 0 && inputNum >= 2 && inputNum <= 25)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                //Is inputNum even and between 26 and 60?
                else if (inputNum % 2 == 0 && inputNum >= 26 && inputNum <= 60)
                {
                    Console.WriteLine("Even.");
                }
                //Is inputNum even and over 60?
                else if (inputNum % 2 == 0 && inputNum > 60)
                {
                    Console.WriteLine(inputNum + " Even.");
                }
                //Is inputNum odd and over 60?
                else if (inputNum % 2 != 0 && inputNum > 60)
                {
                    Console.WriteLine(inputNum + " Odd.");
                }
                //Invalid input
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                //Ask if user wants to continue
                Console.WriteLine("Would you like to continue, " + name + "? y/n:");

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
                    runProgram = false;
                }

            }
            
        }
    }
}
