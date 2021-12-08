using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLeague
{
    public class TableData
    {
        string team;
        int wins;
        int draws;
        int losses;
        int madeGoals;
        int gotGoals;
        int goalDifference;
        int points;

        public TableData(string team)
        {
            this.team = team;
        }

        public string Team { get => team; set => team = value; }
        public int Wins { get => wins; set => wins = value; }
        public int Draws { get => draws; set => draws = value; }
        public int Losses { get => losses; set => losses = value; }
        public int MadeGoals { get => madeGoals; set => madeGoals = value; }
        public int GotGoals { get => gotGoals; set => gotGoals = value; }
        public int GoalDifference { get => goalDifference; set => goalDifference = value; }
        public int Points { get => points; set => points = value; }
    }
}
