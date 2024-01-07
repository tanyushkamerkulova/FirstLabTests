namespace lab1v7
{
    public class FirstPartTest
    {
        FirstPart firstPart = new FirstPart();
        [Fact]
        public void MinIndex_ShouldReturnIndexOfMinimumElement()
        {
            // Arrange
            double[] array = { 3.5, -2.0, 1.0, 7.2, -5.5 };

            // Act
            int result = firstPart.MinIndex(array);

            // Assert
            Assert.Equal(4, result); // Index of the minimum element (-5.5) should be 4
        }

        [Fact]
        public void Summa_ShouldReturnSumOfElementsBetweenFirstAndSecondNegatives()
        {
            // Arrange
            double[] array = { 3.5, -2.0, 1.0, 7.2, -5.5, 2.0, -3.0, 4.5 };

            // Act
            double result = firstPart.Summa(array);

            // Assert
            Assert.Equal(8.2, result);
        }

        [Fact]
        public void Summa_ShouldReturnZeroWhenNoNegatives()
        {
            // Arrange
            double[] array = { 3.5, 2.0, 1.0, 7.2, 5.5, 2.0, 3.0, 4.5 };

            // Act
            double result = firstPart.Summa(array);

            // Assert
            Assert.Equal(0, result); // No negatives, so the sum should be 0
        }

        [Fact]
        public void TransformArray_ShouldTransformArrayCorrectly()
        {
            // Arrange
            double[] array = { 0.5, -2.0, 1.0, 0.2, -5.5, 2.0, -3.0, 0.32 };

            // Act
            firstPart.TransformArray(array);

            // Assert
            double[] expectedArray = { 0.5, 0.2, 0.32, -2.0, 1.0, -5.5, 2.0, -3.0 };
            Assert.Equal(expectedArray, array);
        }
    }
}