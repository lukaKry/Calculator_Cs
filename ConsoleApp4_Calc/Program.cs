using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp4_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of correct calculations availabe in the Calc app 

            List<string> correctChars = new List<string> { "/", "*", "-", "+" };
            bool restart = true;

            while (restart)
            {
                //Calc app opening

                Console.WriteLine("Welcome in the Calc app! What kind of calculation would you like to do: /,  *,  -,  + ");
                Console.WriteLine("Type desired symbol and press enter.");
                string calculation = Console.ReadLine();


                //input validation

                while (!(correctChars.Contains(calculation)))
                {
                    Console.WriteLine("Please, type a valid symbol. Try again.");
                    calculation = Console.ReadLine();
                }

                //First number

                Console.WriteLine("Write first number!");
                string firstNubmer = Console.ReadLine();
                double firstNum;
                bool validation = double.TryParse(firstNubmer, out firstNum);

                while (validation == false)
                {
                    Console.WriteLine("Please, input a valid number. Try again");
                    firstNubmer = Console.ReadLine();
                    validation = double.TryParse(firstNubmer, out firstNum);
                }


                //Second number
                Console.WriteLine("Write second number!");
                string secondNumber = Console.ReadLine();
                double secondNum;
                bool secondValidation = double.TryParse(secondNumber, out secondNum);

                while (secondValidation == false)
                {
                    Console.WriteLine("Please, input a valid number. Try again");
                    secondNumber = Console.ReadLine();
                    secondValidation = double.TryParse(secondNumber, out secondNum);
                }

                double result;

                switch (calculation)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        break;
                    case "/":
                        if (secondNum == 0)
                        {
                            Console.WriteLine("You cannot divide by 0!");
                            result = 0;
                            break;
                        }
                        else
                        {
                            result = firstNum / secondNum;
                            break;
                        }
                    default:
                        result = 0;
                        break;
                }

                Console.WriteLine($"The result is {result}");
                Console.WriteLine(" ");

                //restart question

                Console.WriteLine("Once again? y / n");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    restart = true;
                }
                else if (answer == "n")
                {
                    restart = false;
                }
                else 
                {
                    Console.WriteLine("Wrong answer. Try again.");
                    answer = Console.ReadLine();
                }



            }


            Console.WriteLine("Oh... okey. Bye!");
            Console.WriteLine("           ___");
            Console.WriteLine("        / >    >");
            Console.WriteLine("       |   _  _|");
            Console.WriteLine(@"      / \_'=x=/");
            Console.WriteLine("     /       |");
            Console.WriteLine(@"    /   \    /");
            Console.WriteLine("   _|    | | |");
            Console.WriteLine(" / _|    | | |");
            Console.WriteLine(@"| (  \___\_)_)");
            Console.WriteLine(@" \_)");








        }
    }
}
