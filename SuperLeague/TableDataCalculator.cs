using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLeague
{
    public class TableDataCalculator
    {
        /// <summary>
        /// Diese Methode berechnet für jedes einzelne Team alle Tabelleneinträge.
        /// </summary>
        /// <param name="Team">Ist der Teamname, welcher in der matches-Liste vorhanden ist.</param>
        /// <param name="matches">Ist die entsprechende matches-Liste, wo alle Spiele eingetragen sind.</param>
        /// <returns>Für jedes einzelne Team die TableData mit allen berechneten Daten.</returns>
        public static TableData TeamResult(string Team, List<Match> matches)
        {
            TableData tableResult = new TableData(Team);

            foreach (Match match in matches)
            {
                if (match.HomeTeam == Team) //Hometeam entspricht der zu berechnenden Mannschaft in diesem Match
                {
                    tableResult.MadeGoals += match.HomeGoals;
                    tableResult.GotGoals += match.AwayGoals;

                    if (match.HomeGoals > match.AwayGoals)
                    {
                        tableResult.Points += 3;
                        tableResult.Wins += 1;
                    }
                    else if (match.HomeGoals == match.AwayGoals)
                    {
                        tableResult.Points += 1;
                        tableResult.Draws += 1;
                    }
                    else
                    {
                        tableResult.Losses += 1;
                    }
                }
                else if (match.AwayTeam == Team) //Awayteam entspricht der zu berechnenden Mannschaft in diesem Match
                {
                    tableResult.MadeGoals += match.AwayGoals;
                    tableResult.GotGoals += match.HomeGoals;
                    

                    if (match.HomeGoals < match.AwayGoals)
                    {
                        tableResult.Points += 3;
                        tableResult.Wins += 1;
                    }
                    else if (match.HomeGoals == match.AwayGoals)
                    {
                        tableResult.Points += 1;
                        tableResult.Draws += 1;
                    }
                    else
                    {
                        tableResult.Losses += 1;
                    }
                }
            }
            tableResult.GoalDifference = tableResult.MadeGoals - tableResult.GotGoals;
            return tableResult;
        }
    }
}