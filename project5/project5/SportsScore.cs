using System;

namespace project5
{
    [Serializable]
    internal class SportsScore
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public string VisitorTeam { get; set; }

        public int VisitorScore { get; set; }

        public string HomeTeam { get; set; }

        public int HomeScore { get; set; }

        public SportsScore(int id, string date, string visitorTeam, int visitorScore, string homeTeam, int homeScore)
        {
            Id = id;
            Date = date;
            VisitorTeam = visitorTeam;
            VisitorScore = visitorScore;
            HomeTeam = homeTeam;
            HomeScore = homeScore;
        }
    }
}
