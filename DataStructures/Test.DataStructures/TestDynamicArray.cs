namespace Test.DataStructures
{
    // TODO: Enhance tests
    // TODO: Test the changing of capacity
    // TODO: Add more testing
    public class TestDynamicArray
    {
        [Fact]
        public void Add_ShouldIncreaseCount()
        {
            var dynamicArray = new DynamicArray<int>();
            dynamicArray.Add(10);
            dynamicArray.Add(20);
            dynamicArray.Add(30);

            Assert.Equal(3, dynamicArray.Count);
            Assert.Equal(10, dynamicArray.Get(0));
            Assert.Equal(20, dynamicArray.Get(1));
            Assert.Equal(30, dynamicArray.Get(2));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1)]
        public void Get_ShouldThrow_WhenIndexOutOfBound(int index)
        {
            var dynamicArray = new DynamicArray<string>(10);
            dynamicArray.Add("hello");

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.Get(index));

        }

        [Fact]
        public void Set_ShouldUpdateValue()
        {
            var dynamicArray = new DynamicArray<string>();
            dynamicArray.Add("Jose");
            var oldCount = dynamicArray.Count;
            
            dynamicArray.Set(0, "Cristian");
            var newCount = dynamicArray.Count;

            Assert.Equal(oldCount, newCount);
            Assert.Equal("Cristian", dynamicArray.Get(0));
        }

        [Fact]
        public void InsertAt_ShouldInsertCorrectly()
        {
            var dynamicArray = new DynamicArray<string>();
            dynamicArray.Add("Jose");
            dynamicArray.Add("Jessica");

            dynamicArray.InsertAt(1, "Cristian");

            Assert.Equal(3, dynamicArray.Count);
            Assert.Equal("Jose", dynamicArray.Get(0));
            Assert.Equal("Cristian", dynamicArray.Get(1));
            Assert.Equal("Jessica", dynamicArray.Get(2));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3)]
        public void InsertAt_ShouldThrow_WhenOutOfRange(int index)
        {
            var dynamicArray = new DynamicArray<int>();
            dynamicArray.Add(1);
            dynamicArray.Add(2);

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.InsertAt(index, 23));

        }

        [Theory]
        [InlineData(1)]
        [InlineData(-1)]
        [InlineData(-100)]
        public void RemoveAt_ShouldThrow_WhenOutOfRange(int index)
        {
            var dynamicArray = new DynamicArray<int>();
            dynamicArray.Add(1);

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.RemoveAt(index));
        }

        [Fact]
        public void NewDynamicArray_ShouldHaveDefaultCapacityOf10()
        {
            var dynamicArray = new DynamicArray<int>();

            Assert.Equal(10, dynamicArray.Capacity);

        }

        [Fact]
        public void Add_ShouldIncreaseCapacityBy2WhenRequired()
        {
            var dynamicArray = new DynamicArray<int>(2);
            dynamicArray.Add(25);
            dynamicArray.Add(55);
            var oldCapacity = dynamicArray.Capacity;

            dynamicArray.Add(65);
            var newCapacity = dynamicArray.Capacity;

            Assert.True(newCapacity == oldCapacity * 2);
            Assert.True(oldCapacity < newCapacity);

        }

        [Fact]
        public void Set_ShouldMaintainCapacity()
        {
            var dynamicArray = new DynamicArray<int>(2);
            dynamicArray.Add(25);
            dynamicArray.Add(55);
            var oldCapacity = dynamicArray.Capacity;

            dynamicArray.Set(1, 6);
            var newCapacity = dynamicArray.Capacity;

            Assert.Equal(oldCapacity, newCapacity);

        }

        [Fact]
        public void InsertAt_AboveCurrentCapacity_ShouldIncreaseCapacity()
        {
            var dynamicArray = new DynamicArray<string>(1);
            dynamicArray.Add("test");
            var oldCapacity = dynamicArray.Capacity;

            dynamicArray.InsertAt(0, "newTest");
            var newCapacity = dynamicArray.Capacity;

            Assert.True(oldCapacity < newCapacity);

        }

        [Fact]
        public void InsertAt_ShouldThrowExceptionWithNegativeIndex()
        {
            var dynamicArray = new DynamicArray<string>(1);

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.InsertAt(-1, "newTest"));

        }

        [Fact]
        public void InsertAt_ShouldThrowExceptionWhenIndexGreaterThanCount()
        {
            var dynamicArray = new DynamicArray<string>(1);

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.InsertAt(3, "newTest"));

        }

        [Theory]
        [InlineData(-1)]
        [InlineData(5)]
        [InlineData(12)]

        public void InsertAt_ShouldThrowExceptionWithInvalidIndexes(int index)
        {
            var dynamicArray = new DynamicArray<string>(1);

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.InsertAt(index, "newTest"));

        }

        [Theory]
        [InlineData(-5)]
        [InlineData(3)]

        public void RemoveAt_ShouldThrowExceptionWithInvalidIndexes(int index)
        {
            var dynamicArray = new DynamicArray<string>(1);

            Assert.Throws<ArgumentOutOfRangeException>(() => dynamicArray.RemoveAt(index));

        }

    }
}