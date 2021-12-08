using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SuperLeague.Tests
{
    public class StartupTest
    {
        [Fact]
        public void TestReadMatches()
        {
            //Give
            string debugDirectory = Directory.GetCurrentDirectory();
            string fileDirectory = debugDirectory.Substring(0, debugDirectory.Length - 35);
            string jsonPath = fileDirectory + "\\data\\league.json";

            //When
            var matches = Startup.ReadMatches(jsonPath);

            //Then
            Assert.NotNull(matches);
        }
    }
}
