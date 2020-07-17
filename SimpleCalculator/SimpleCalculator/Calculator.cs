using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;

namespace SimpleCalculator
{
    public class Calculator
    {
        private double total;

        public Calculator()
        {
            this.total = 0.0;
        }


       


        /// <summary method = 'typeOfCalculation'>
        /// This method takes a (char typeOfCalculation) +,-,/,* in order to determine what to do to the current total. 
        /// A number is entered(double enteredNumber) and the total is then manipulated. 
        /// </summary>
        /// <param name="typeOfCalculation"></param>
        /// <param name="enteredNumber"></param>
        public void CalculateAnswer(char typeOfCalculation, double firstNumber, double secondNumber)
        {
            if(typeOfCalculation.Equals('+'))
            {
                this.Add(firstNumber, secondNumber); 
            }
            else if(typeOfCalculation.Equals('-'))
            {
                this.Subtract(firstNumber, secondNumber);
            }
            else if(typeOfCalculation.Equals('/'))
            {
                this.Divide(firstNumber, secondNumber);
            }
            else if(typeOfCalculation.Equals('*'))
            {
                this.Multiply(firstNumber, secondNumber);
            }
        }

        public void CalculateAnswer(char typeOfCalculation, double firstNumber, double secondNumber, double thirdNumber)
        {
            if (typeOfCalculation.Equals('+'))
            {
                this.Add(firstNumber, secondNumber, thirdNumber);
            }
            else if (typeOfCalculation.Equals('-'))
            {
                this.Subtract(firstNumber, secondNumber, thirdNumber);
            }
            else if (typeOfCalculation.Equals('/'))
            {
                this.Divide(firstNumber, secondNumber, thirdNumber);
            }
            else if (typeOfCalculation.Equals('*'))
            {
                this.Multiply(firstNumber, secondNumber, thirdNumber);
            }
        }

        public void Add(double firstNumber, double secondNumber)
        {
            this.total = firstNumber + secondNumber; 
        }

        public void Add(double firstNumber, double secondNumber, double thirdNumber)
        {
            this.total = firstNumber + secondNumber + thirdNumber;
        }
        public void Subtract(double firstNumber, double secondNumber)
        {
            this.total = firstNumber - secondNumber;
        }
        public void Subtract(double firstNumber, double secondNumber, double thirdNumber)
        {
            this.total = firstNumber - secondNumber - thirdNumber;
        }

        public void Multiply(double firstNumber, double secondNumber)
        {
            this.total = firstNumber * secondNumber;
        }

        public void Multiply(double firstNumber, double secondNumber, double thirdNumber)
        {
            this.total = firstNumber * secondNumber * thirdNumber;
        }

        public void Divide(double firstNumber, double secondNumber)
        {
            this.total = firstNumber / secondNumber;
        }

        public void Divide(double firstNumber, double secondNumber, double thirdNumber)
        {
            this.total = firstNumber / secondNumber/ thirdNumber;
        }

        /*public void Mod(double firstNumber, double secondNumber)
        {
            this.total = firstNumber % secondNumber;
        }
        */

        public double getTotal()
        {
            return this.total; 
        }
        public void setTotal(double total)
        {
            this.total = total; 
        }
    }
}
