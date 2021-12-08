using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace SuperLeague
{
    public class Startup
    {
        static void Main(string[] args)
        {
            string jsonPath;
            if (args.Length == 0)
            {
                jsonPath = getPathOfLeagueJson();

            }
            else
            {
                jsonPath = args[0];
            }
            List<Match> matches = new List<Match>();
            matches = ReadMatches(jsonPath);
            Console.WriteLine(Table.CreateTable(matches));
        }

        public static string getPathOfLeagueJson()
        {
            string debugDirectory = Directory.GetCurrentDirectory();
            string fileDirectory = debugDirectory.Substring(0, debugDirectory.Length - 29);
            string jsonPath = fileDirectory + "\\data\\league.json";
            return jsonPath;          
        }

        public static List<Match> ReadMatches(string jsonPath)
        {
            using (StreamReader r = new StreamReader(jsonPath))
            {
                string json = r.ReadToEnd();
                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(json);
                return matches;
            }
        }
    }
}
