using System;
using Xunit;
using SimpleCalculator;
using AutoFixture;

namespace SimpleCalculatorTests
{
    public class SimpleCalculatorTest
    {
        [Fact]
        public void Calculator_Add_PositiveNumbers()
        {

            var sut = new Calculator(); 

            Fixture fixture = new Fixture();

          

            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('+', firstNumber, secondNumber);

            double result = sut.getTotal(); 

            double expected = firstNumber + secondNumber;

            Assert.Equal(expected, result);


        }



        [Fact]

        public void Calculator_Add_NegativeNumbers()
        {

            var sut = new Calculator();

            Fixture fixture = new Fixture();
            fixture.Customizations.Add(
            new RandomNumericSequenceGenerator(-999, -1)
            ); 


            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('+', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber + secondNumber;

            Assert.Equal(expected, result);


        }

        [Fact]

        public void Calculator_Subtract_PositiveNumbers()
        {

            var sut = new Calculator();

            Fixture fixture = new Fixture();


            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('-', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber - secondNumber;

            Assert.Equal(expected, result);


        }

        [Fact]

        public void Calculator_Subtract_NegativeNumbers()
        {

            var sut = new Calculator();

            Fixture fixture = new Fixture();
            fixture.Customizations.Add(
            new RandomNumericSequenceGenerator(-999, -1)
            );


            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('-', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber - secondNumber;

            Assert.Equal(expected, result);


        }


        [Fact]

        public void Calculator_Multiply_PositiveNumbers()
        {
            var sut = new Calculator();

            Fixture fixture = new Fixture();
           
            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('*', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber * secondNumber;

            Assert.Equal(expected, result);
        }

        [Fact]

        public void Calculator_Multiply_NegativeNumbers()
        {

            var sut = new Calculator();

            Fixture fixture = new Fixture();
            fixture.Customizations.Add(
            new RandomNumericSequenceGenerator(-999, -1)
            );

            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('*', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber * secondNumber;

            Assert.Equal(expected, result);


        }

        [Fact]

        public void Calculator_Divide_PositiveNumbers()
        {

            var sut = new Calculator();

            Fixture fixture = new Fixture();

            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('/', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber / secondNumber;

            Assert.Equal(expected, result);

        }

        [Fact]

        public void Calculator_Divide_NegativeNumbers()
        {
            var sut = new Calculator();

            Fixture fixture = new Fixture();
            fixture.Customizations.Add(
            new RandomNumericSequenceGenerator(-999, -1)
            );

            double firstNumber = fixture.Create<Double>();
            double secondNumber = fixture.Create<Double>();

            sut.CalculateAnswer('/', firstNumber, secondNumber);

            double result = sut.getTotal();

            double expected = firstNumber / secondNumber;

            Assert.Equal(expected, result);

        }

    }
}
