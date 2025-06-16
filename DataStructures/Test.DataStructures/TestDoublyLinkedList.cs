namespace Test.DataStructures
{
    public class TestDoublyLinkedList
    {
        [Fact]
        public void AddFirst_ShouldInsertAtFront()
        {
            var list = new DoublyLinkedList<string>();
            list.AddFirst("Carlos");
            list.AddFirst("Sergio");
            list.AddFirst("Fabricio");

            var result = list.Get(0);

            Assert.Equal("Fabricio", result);
        }

        [Fact]
        public void AddLast_ShouldInsertAtEnd()
        {
            var list = new DoublyLinkedList<string>();
            list.AddLast("Carlos");
            list.AddLast("Sergio");
            list.AddLast("Fabricio");

            var result = list.Get(2);

            Assert.Equal("Fabricio", result);
        }

        [Fact]
        public void ToReversedArray_ShouldReturnCorrectReverseOrder()
        {
            // TODO: Complete the test
            var list = new DoublyLinkedList<int>();
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(1);

            Assert.Equal(new[] {1, 2, 3}, list.ToReversedArray());
        }

        [Fact]
        public void Get_ShouldReturnCorrectElement()
        {
            // TODO: Complete the test
            var doublyList = new DoublyLinkedList<char>();
            doublyList.AddFirst('A');
            doublyList.AddFirst('B');
            doublyList.AddFirst('C');

            Assert.Equal('A', doublyList.Get(0));
            Assert.Equal('B', doublyList.Get(1));
            Assert.Equal('C', doublyList.Get(2));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(2)]
        public void Get_ShouldThrow_WhenIndexInvalid(int index)
        {
            // TODO: Complete test
            var doublyList = new DoublyLinkedList<string>();

            Assert.Throws<ArgumentOutOfRangeException>(() => doublyList.Get(index));
        }

        [Fact]
        public void Contains_ShouldReturnTrueIfValueExists()
        {
            // TODO: Complete test
            var doublyList = new DoublyLinkedList<string>();
            doublyList.AddFirst("Carlos"); 

            Assert.True(doublyList.Contains("Carlos"));
        }

        [Fact]
        public void Remove_ShouldRemoveExistingValue()
        {
            // TODO: Complete test
            var list = new DoublyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            var result = list.TryRemove(2);

            Assert.True(result);
            Assert.Equal(2, list.Count);
            Assert.Equal(new[] { 1, 3 }, list.ToArray());
        }

        [Fact]
        public void Remove_ShouldReturnFalseIfNotFound()
        {
            // TODO: Complete test
            var list = new DoublyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            var result = list.TryRemove(4);

            Assert.False(result);
            Assert.Equal(3, list.Count);
            Assert.Equal(new[] { 1, 2, 3 }, list.ToArray());
        }

        // OPTIONAL: Add more tests if wanted

        [Fact]
        public void ToArray_ShouldReturnArrayWithAllElementsInDoublyLinkedList()
        {
            var list = new DoublyLinkedList<string>();
            list.AddLast("Carlos");
            list.AddLast("Sergio");
            list.AddLast("Fabricio");

            var array = list.ToArray();

            Assert.NotNull(array);
            Assert.Equal(new[] { "Carlos", "Sergio", "Fabricio" }, array);
        }

        [Fact]
        public void ToReversedArray_ShouldReturnReversedArrayOfDoublyLinkedList()
        {
            var list = new DoublyLinkedList<string>();
            list.AddLast("Carlos");
            list.AddLast("Sergio");
            list.AddLast("Fabricio");

            var array = list.ToReversedArray();

            Assert.NotNull(array);
            Assert.Equal(new[] { "Fabricio", "Sergio", "Carlos" }, array);
        }
    }
}
