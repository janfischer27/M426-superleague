using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SuperLeague
{
    public class Table
    {
        public static string CreateTable(List<Match> matches)
        {
            List<string> teamList = new List<string>();
            List<TableData> rows = new List<TableData>();

            foreach (Match match in matches)
            {
                if (!teamList.Contains(match.HomeTeam))
                {
                    teamList.Add(match.HomeTeam);
                }
                
                if (!teamList.Contains(match.AwayTeam))
                {
                    teamList.Add(match.AwayTeam);
                }
            }
                        
            foreach (string team in teamList)
            {
                rows.Add(TableDataCalculator.TeamResult(team, matches));
            }

            return ToString(rows);
        }

        public static string ToString(List<TableData> rows)
        {
            sortTable(rows);
            StringWriter output = new();
            output.WriteLine("{0,-30} {1,5} {2,5} {3,5} {4,5} {5,5} {6,5} {7,5} {8,5}", "Name", "#", "w", "d", "l", "+", "-", "=", "P");
            output.WriteLine("-------------------------------------------------------------------------------");
            int rank = 1;
            foreach (TableData row in rows)
            {
                output.WriteLine($"{row.Team, -30} {rank, 5} {row.Wins, 5} {row.Draws, 5} {row.Losses, 5} {row.MadeGoals, 5} {row.GotGoals, 5} {row.GoalDifference, 5} {row.Points, 5}");
                rank++;
            }
            return output.ToString();
        }

        public static List<TableData> sortTable(List<TableData> table) 
        {
            table.Sort((team1, team2) =>
            {
                if (team1.Points > team2.Points)
                {
                    return -1;
                } 
                else if (team1.Points < team2.Points)
                {
                    return 1;
                } 
                else if (team1.GoalDifference > team2.GoalDifference)
                {
                    return -1;
                } 
                else if (team1.GoalDifference < team2.GoalDifference)
                {
                    return 1;
                }
                else if (team1.Wins > team2.Wins)
                {
                    return -1;
                }
                else if (team1.Wins < team2.Wins)
                {
                    return 1;
                }
                else
                {
                    return team1.Team.CompareTo(team2.Team);
                }
            });
            return table;
        }
    }
}