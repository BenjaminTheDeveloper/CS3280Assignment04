# CS3280Assignment07
	Clean Calculator 

# Purpose

	The purpose of this assignment is to learn to use unit testing with autofixtures.
	This assignment is meant to add two numbers but contains a third number option. 
	By adding Unit Testing this program is now more viable. 

# Code 
	
	public class Calculator():
			
		Variables:
			- private double total
		Methods: 
			- void CalculateAnswer() has been overloaded to allow for a third number as well.
			- void Add() adds two to three numbers.
			- void Subtract() subtracts two to three numbers in order. 
			- void Multiply() multiplies two to three numbers together.
			- void Divide() divides two to three numbers in order. 
	
	public class CalculatorDriver():
		
		Variables: 

			- private string parameterChoice = "";
        		- private string mathChoice;
       			- private string continueKey = " ";
        		- private string stopKey = "q";
        		- private double firstNumber, secondNumber, thirdNumber;
        		- private Calculator calculator = new Calculator(); 
		Methods: 
			The main purpose of the driver is to keep the main program clean, it contains two while loops. 
			The first while loop runs the two numbers calculation, the second while loop runs the three numbers calculation. 

# Unit Testing 

	The Unit Testing provided tests each math method inside of the Calculator Class. The first test for each method is tested using positive numbers. 
	The second test used for each method is tested with negative numbers. Each number is generated randomly using AutoFixture.
 
		

