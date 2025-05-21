using Generics;

namespace Test.Generics
{
    public class TestSafeBox
    {
        // TODO: Add positive scenario
        [Fact]
        public void SafeBox_ShouldReturnGivenValue()
        {
            string test = "test1";
            var safeBox = new SafeBox<string>(test);
            Assert.NotNull(safeBox);

        }

        [Fact]
        public void SafeBox_ShouldThrowIfNull()
        {
            Assert.Throws<ArgumentNullException>(() => new SafeBox<string>(null));
        }
    }
}
