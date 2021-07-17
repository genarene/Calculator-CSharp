using System;
using System.Collections.Generic;


namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            // a check to terminate the program
            string exit = "";
            char myOperator;

            // variables to store the numbers entered by user
            double num1, num2;

            // creating and storing the calculation history
            List<CalculationHistory> history = new List<CalculationHistory>();
            Console.WriteLine("Heey there ...This is your Calculator");

            // calculation logic
            do
            {




                Console.WriteLine("Enter the operator (+,-,*,/,^)");

                //  to read the operator that will be entered by the user
                // read the character at index [0] 
                myOperator = Console.ReadLine()[0];




                //    ask user to enter the calculation numbers
                num1 = SetNumber("Type you first number : ");


                num2 = SetNumber("Type you second number : ");


                // printing the calculation history
                System.Console.WriteLine("<<<<<<<<Calculation hisory>>>>>>>>>>>");

                foreach (var calcHistory in history)
                {
                    System.Console.WriteLine(calcHistory.calculation);
                }

                System.Console.WriteLine("<<<<<<<<Calculation hisory>>>>>>>>>>>");


                System.Console.WriteLine("******Current Calculation ****");


                //   calculation logic 
                switch (myOperator)
                {
                    //   addition
                    // begin with index zero to be less than the size of argument list

                    case '+':
                        Console.WriteLine("{0}+{1}={2}", num1, num2, (num1 + num2));
                        history.Add(new CalculationHistory(num1, num2, myOperator, (num1 + num2)));

                        break;

                    //  subtraction
                    case '-':
                        Console.WriteLine("{0}-{1}={2}", num1, num2, (num1 - num2));
                        history.Add(new CalculationHistory(num1, num2, myOperator, (num1 - num2)));


                        break;

                    //  multiplication
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", num1, num2, (num1 * num2));
                        history.Add(new CalculationHistory(num1, num2, myOperator, (num1 * num2)));


                        break;

                    //  division
                    // first check if there is a zero input in num2
                    case '/':
                        if (num2 == 0.0)
                        {
                            Console.WriteLine("you cannot divide by zero");
                        }

                        else
                        {
                            Console.WriteLine("{0}/{1}={2}", num1, num2, (num1 / num2));
                            history.Add(new CalculationHistory(num1, num2, myOperator, (num1 / num2)));



                        }
                        break;

                    // square the two numbers
                    case '^':
                        System.Console.WriteLine("{0}^{1}={2}", num1, num2, (Math.Pow(num1, num2)));
                        history.Add(new CalculationHistory(num1, num2, myOperator, (Math.Pow(num1, num2))));

                        break;
                    default:
                        Console.WriteLine("invalid operator", myOperator);
                        break;

                }
                // to allow one to enter any key to exit or continue the program
                Console.WriteLine("Type exit to quit, anything else to continue");
                exit = Console.ReadLine();
            } while (exit != "exit");


        }

        // validate the inputs to ensure they are numbers
        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }
    }
}
