using System;
using System.Collections.Generic;
using Xunit;
using System.IO;

namespace SuperLeague.Tests
{
    public class TableTest
    {
        [Fact]
        public void TestCreateTableAndToStringMethode()
        {
            //Give
            List<Match> testMatch = new()
            {
                new Match("FCL", "FCB", 5, 0),
            };

            //When
            string result = Table.CreateTable(testMatch);

            //Then
            string fullExpectedTable =
                 "Name                               #     w     d     l     +     -     =     P\r\n" 
                +"-------------------------------------------------------------------------------\r\n" 
                +"FCL                                1     1     0     0     5     0     5     3\r\n"
                +"FCB                                2     0     0     1     0     5    -5     0\r\n";
            
            Assert.Equal(fullExpectedTable, result);
        }

        [Fact]
        public void TestSortTable()
        {
            //Give
            string debugDirectory = Directory.GetCurrentDirectory();
            string fileDirectory = debugDirectory.Substring(0, debugDirectory.Length - 35);
            string jsonPath = fileDirectory + "\\data\\sorting.json";

            //When
            var sortingTest = Startup.ReadMatches(jsonPath);
            var sortingResult = Table.CreateTable(sortingTest);

            //Then
            string expectedSorting = 
                "Name                               #     w     d     l     +     -     =     P\r\n"
               +"-------------------------------------------------------------------------------\r\n"
               +"y                                  1     1     3     0     1     0     1     6\r\n"
               +"x                                  2     1     0     1     2     1     1     3\r\n"
               +"a                                  3     1     0     1     1     2    -1     3\r\n"
               +"b                                  4     0     3     1     0     1    -1     3\r\n";

            Assert.Equal(expectedSorting, sortingResult);
        }
    }
}
