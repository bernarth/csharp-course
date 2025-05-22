using Generics;

namespace Test.Generics
{
    public class TestCalculator
    {
        // TODO: Add tests

        [Fact]
        public void SumOfIntegers_ShouldReturnResultSum()
        {
            int number1 = 10;
            int number2 = 20;
            int resultSum = 30;
            var calculator = new Calculator<int>();
            var result = calculator.Add(number1, number2);

            Assert.Equal(resultSum, result);
        }

        [Fact]
        public void SumOfDecimals_ShouldReturnResultSum()
        {
            decimal number1 = 1.20m;
            decimal number2 = 20.10m;
            decimal resultSum = 21.30m;
            var calculator = new Calculator<decimal>();
            var result = calculator.Add(number1, number2);

            Assert.Equal(resultSum, result);
        }

        [Fact]
        public void SubstractionOfIntegers_ShouldReturnResult()
        {
            int number1 = 30;
            int number2 = 20;
            int resultSub = 10;
            var calculator = new Calculator<int>();
            var result = calculator.Substract(number1, number2);

            Assert.Equal(resultSub, result);
        }

        [Fact]
        public void SubstractionOfDecimals_ShouldReturnResult()
        {
            decimal number1 = 10.20m;
            decimal number2 = 2.10m;
            decimal resultSub = 8.10m;
            var calculator = new Calculator<decimal>();
            var result = calculator.Substract(number1, number2);

            Assert.Equal(resultSub, result);
        }

        [Fact]
        public void MultiplicationOfIntegers_ShouldReturnResult()
        {
            int number1 = 3;
            int number2 = 2;
            int resultMul = 6;
            var calculator = new Calculator<int>();
            var result = calculator.Multiply(number1, number2);

            Assert.Equal(resultMul, result);
        }

        [Fact]
        public void MultiplicationOfDecimals_ShouldReturnResult()
        {
            decimal number1 = 10.20m;
            decimal number2 = 2.10m;
            decimal resultSub = 21.42m;
            var calculator = new Calculator<decimal>();
            var result = calculator.Multiply(number1, number2);

            Assert.Equal(resultSub, result);
        }

        [Fact]
        public void MultiplicationByZero_ShouldReturnZero()
        {
            int number1 = 10;
            int number2 = 0;
            var calculator = new Calculator<int>();
            var result = calculator.Multiply(number1, number2);

            Assert.Equal(0, result);
        }

        [Fact]
        public void MultiplicationBetweenNegatives_ShouldReturnPositiveNumber()
        {
            int number1 = -10;
            int number2 = -20;
            var calculator = new Calculator<int>();
            var result = calculator.Multiply(number1, number2);

            Assert.Equal(200, result);

        }

        [Fact]
        public void DivisionOfIntegers_ShouldReturnResult()
        {
            int number1 = 3;
            int number2 = 1;
            int resultDiv = 3;
            var calculator = new Calculator<int>();
            var result = calculator.Divide(number1, number2);

            Assert.Equal(resultDiv, result);
        }

        [Fact]
        public void DivisionOfDecimals_ShouldReturnResult()
        {
            decimal number1 = 10.20m;
            decimal number2 = 2.20m;
            decimal resultDiv = 4.6363636363636363636363636364m;
            var calculator = new Calculator<decimal>();
            var result = calculator.Divide(number1, number2);

            Assert.Equal(resultDiv, result);
        }

        [Fact]
        public void DivisionByZero_ShouldThrowDivisionByZeroException()
        {
            int number1 = 5;
            int number2 = 0;
            var calculator = new Calculator<int>();

            Assert.Throws<DivideByZeroException>(() => calculator.Divide(number1, number2));
        }
    }
}
