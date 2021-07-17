using System;

namespace MyCalculator
{
    // a class to generate my calculation history
    public class CalculationHistory
    {
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public char stringOperation { get; set; }

        public double results { get; set; }
        public string calculation { get; set; }

        public CalculationHistory(double firstNum, double secondNum, char op, double result)
        {
            firstNumber = firstNum;
            secondNumber = secondNum;
            stringOperation = op;
            results = result;

            calculation = Convert.ToString(firstNumber + " " + op + " " + secondNumber + "=" + results);
        }
    }
}