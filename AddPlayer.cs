using System;
using System.Windows.Forms;

namespace Lab_4_S_A
{
    public partial class AddPlayer : Form 
    {
        int amount_of_p;
        int Y_card;
        int R_card;
        int Goals;
        Team curteam = null;
        int it_of_players = 1;
        bool redact_mode = false;
        Player[] players = null;
        int id_red_p;
        DateTime tmp = DateTime.Now;
        public AddPlayer(int amount_of_p,Team curteam)
        {
            InitializeComponent();
            this.amount_of_p = amount_of_p;
            this.curteam = curteam;
            T_on_fieldBox.Text = "01:00:00";
        }
        public AddPlayer(int p_id, Player[] players)
        {
            InitializeComponent();
            redact_mode = true;
            label8.Text = $"#{p_id}";
            p_id --;            
            FIOBox.Text = players[p_id].PName;
            T_on_fieldBox.Text = players[p_id].PTimeOnField;
            R_cardsBox.Text = players[p_id].PRedCards.ToString();
            Y_cardsBox.Text = players[p_id].PYellowCards.ToString();
            GoalsBox.Text = players[p_id].PGoal.ToString();
            id_red_p = p_id;
            this.players = players;
        }

        private void b_stage_1_Click(object sender, EventArgs e)
        {
            Program.validation = true;
            Program.checkParsing(R_cardsBox, ref R_card, "Enter valid amount of red cards");
            Program.checkParsing(Y_cardsBox,ref Y_card, "Enter valid amount of yellow cards");
            Program.checkParsing(GoalsBox,ref Goals, "Enter valid amount of goals");
            Program.checkParsing(FIOBox, 6, 20, "Length is not in available range");
            Program.validation = Program.checkParsing(T_on_fieldBox.Text, ref tmp);
            Program.checkParsing(T_on_fieldBox, 8, 8, "Length is not in available range");
            if (!redact_mode && Program.validation == true)
            {
                if (it_of_players <= amount_of_p )
                {
                    Player p = new Player(FIOBox.Text, Goals, T_on_fieldBox.Text, R_card, Y_card);
                    curteam.Players[it_of_players - 1] = p;
                    FIOBox.Clear();
                    it_of_players++;
                    label8.Text = $"#{it_of_players}";
                }
                if (it_of_players > amount_of_p)
                {
                    this.Close();
                }
            }
            else if(Program.validation == true)
            {
                players[id_red_p].PName = FIOBox.Text;
                players[id_red_p].PTimeOnField = T_on_fieldBox.Text;
                players[id_red_p].PGoal = Goals;
                players[id_red_p].PRedCards = R_card;
                players[id_red_p].PYellowCards = Y_card;
                this.Close();
            }
        }
    }
}
