using System.Collections.Generic;
using Xunit;

namespace SuperLeague.Tests
{
    public class TableDataCalculatorTest
    {
        [Fact]
        public void TestSorting()
        { 
            //Give
            List<Match> matchesTest = new()
            {
                new Match("FCL", "FCB", 4, 0),
                new Match("FCZ", "FCL", 2, 2),
                new Match("FCG", "FCS", 9, 4),
                new Match("FCL", "FCG", 0, 7)
            };

            //When
            TableData testResults = TableDataCalculator.TeamResult("FCL", matchesTest);

            //Then
            Assert.Equal(4, testResults.Points);
            Assert.Equal(6, testResults.MadeGoals);
            Assert.Equal(9, testResults.GotGoals);
            Assert.Equal(1, testResults.Wins);
            Assert.Equal(1, testResults.Draws);
            Assert.Equal(1, testResults.Losses);
        }
    }
}
