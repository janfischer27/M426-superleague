namespace SuperLeague
{
    public class Match
    {
        public string HomeTeam { get; }
        public string AwayTeam { get; }
        public int HomeGoals { get; }
        public int AwayGoals { get; }

        public Match(string homeTeam, string awayTeam, int homeGoals, int awayGoals)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.HomeGoals = homeGoals;
            this.AwayGoals = awayGoals;
        }

        public override string ToString()
        {
            return $"{this.HomeTeam} {this.HomeGoals}:{this.AwayGoals} {this.AwayTeam}";
        }
    }
}
