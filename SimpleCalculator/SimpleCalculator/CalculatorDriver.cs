using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class CalculatorDriver
    {


        private string parameterChoice = "";
        private string mathChoice;
        private string continueKey = " ";
        private string stopKey = "q";

        private double firstNumber, secondNumber, thirdNumber;

        private Calculator calculator = new Calculator();

        public CalculatorDriver()
        {

        }

        public void Run()
        {
            Console.WriteLine("Simple Calculator");


            Console.WriteLine("- Two Numbers (a)\n- (Bonus)Three Numbers(b)");
            parameterChoice = Console.ReadLine();


            if (parameterChoice.Equals("a"))
            {
                while (!(continueKey.Equals(stopKey)))
                {


                    Console.WriteLine("First Number: ");
                    firstNumber = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Second Number: ");
                    secondNumber = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Would you like to (+, -, *, /)?");
                    mathChoice = Console.ReadLine();

                    calculator.CalculateAnswer(Char.Parse(mathChoice), firstNumber, secondNumber);


                    Console.WriteLine("Current Total: " + calculator.getTotal());

                    calculator.setTotal(0.00);

                    Console.WriteLine("Press any key to continue calculating or 'q' to QUIT");
                    continueKey = Console.ReadLine();
                }
            }
            else if (parameterChoice.Equals("b"))
            {
                Console.WriteLine("You are in three numbers mode");
                while (!(continueKey.Equals(stopKey)))
                {

                   
                     Console.WriteLine("First Number: ");
                     firstNumber = Double.Parse(Console.ReadLine());
                    
                    

                    Console.WriteLine("Second Number: ");
                    secondNumber = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Third Number: ");
                    thirdNumber = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Would you like to (+, -, *, /)?");

                    mathChoice = Console.ReadLine();

                    calculator.CalculateAnswer(Char.Parse(mathChoice), firstNumber, secondNumber, thirdNumber);


                    Console.WriteLine("Current Total: " + calculator.getTotal());

                    calculator.setTotal(0.00);

                    Console.WriteLine("Press any key to continue calculating or 'q' to QUIT");
                    continueKey = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("You did not enter a correct choice!");
            }


        }
    }
}
