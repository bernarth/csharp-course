using Generics;

namespace Test.Generics
{
    public class TestPrinter
    {
        // TODO: Add more tests for Printer

        [Fact]
        public void GetOrDefault_SHouldReturnDefaultIfNull()
        {
            var printer = new Printer();
            string result = printer.GetOrDefault<string>(null);
            Assert.Null(result);
        }

        [Fact]
        public void GetOrDefault_SHouldReturnGivenValue()
        {
            var printer = new Printer();
            int result = printer.GetOrDefault(10);
            Assert.Equal(10, result);
        }

        [Fact]
        public void GetOrDefault_ShouldReturnZeroAsIntDefault()
        {
            var printer = new Printer();
            int result = printer.GetOrDefault(0);
            Assert.Equal(0, result);

        }

        [Fact]
        public void GetOrDefault_ShouldReturnGivenIntValue()
        {
            var printer = new Printer();
            int result = printer.GetOrDefault(10);
            Assert.Equal(10, result);
        }


        [Fact]
        public void GetOrDefault_ShouldReturnFalseForBoolDefaultValue()
        {
            var printer = new Printer();
            bool result = printer.GetOrDefault(false);
            Assert.False(result);

        }

        [Fact]
        public void GetOrDefault_ShouldReturnGivenBoolValue()
        {
            var printer = new Printer();
            bool result = printer.GetOrDefault(true);
            Assert.True(result);
        }
    }
}
