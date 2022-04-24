namespace Lab_4_S_A
{
    public class Team
    {
        public string TName;
        public int TScore;
        public Player[] Players;
        public int Am_of_pl;
        
    }
    public class Player
    {
        public string PName;
        public int PGoal;
        public string PTimeOnField;
        public int PRedCards;
        public int PYellowCards;
        public Player(string PName,int PGoal, string PTimeOnField, int PRedCards, int PYellowCards)
        {
            this.PName = PName;
            this.PGoal = PGoal;
            this.PRedCards = PRedCards;
            this.PYellowCards = PYellowCards;
            this.PTimeOnField = PTimeOnField;
        }
    }
}
