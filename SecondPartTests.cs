using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1v7
{
    public class SecondPartTests
    {
        SecondPart secondPart = new SecondPart();
        [Fact]
        public void SortColumnsByCharacteristics_ShouldSortColumnsCorrectly()
        {
            int[,] matrix = {
            { 3, -2, 1 },
            { -5, 4, 7 },
            { 0, -1, 2 }
        };

            int[,] expectedMatrix = {
            { 1, -2, 3 },
            { 7, 4, -5 },
            { 2, -1, 0 }
        };

            secondPart.SortColumnsByCharacteristics(matrix);

            Assert.Equal(expectedMatrix, matrix);
        }

        [Fact]
        public void SumColumnsWithNegatives_ShouldReturnSumCorrectly()
        {
            int[,] matrix = {
            { 3, -2, 1 },
            { -5, 4, 7 },
            { 0, -1, 2 }
        };

            int result = secondPart.SumColumnsWithNegatives(matrix);
            Assert.Equal(-1, result);
        }
    }
}
