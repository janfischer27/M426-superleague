using System;
using Xunit;

namespace SuperLeague.Tests
{
    public class MatchTest
    {
        [Fact]
        public void TestToString()
        {
            //Give
            var homeTeam = "FCL";
            var awayTeam = "FCZ";
            var homeGoals = 2;
            var awayGoals = 3;
            Match match = new Match(homeTeam, awayTeam, homeGoals, awayGoals);

            //When
            var actual = match.ToString();

            //Then
            Assert.Equal("FCL 2:3 FCZ", actual);
        }
    }
}
