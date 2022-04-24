using System;
using System.Windows.Forms;


namespace Lab_4_S_A
{

    public partial class ToAddForm : Form
    {
        public ToAddForm()
        {
            InitializeComponent();            
            monthCalendar1.MaxSelectionCount = 1;
        }
        Team team1 = new Team();
        Team team2 = new Team();
        bool New_stage = false;
        string Date_of_match;

        // указывает будет ли произведен переход на вкладку кнопкой
        private void button1_Click(object sender, EventArgs e)
        {
            team1.TName = Team1_box.Text;
            team2.TName = Team2_box.Text;
            New_stage = Program.validation = true;           
            Program.checkParsing(ScoreBox1, ref team1.TScore, "Enter valid data");
            Program.checkParsing(ScoreBox2, ref team2.TScore, "Enter valid data");
            New_stage = Program.validation;
            if (New_stage)
            {
                Tab_ctrl.SelectTab(1);
            }                      
        }

        private void B_stage_2_Click(object sender, EventArgs e)
        {
            New_stage = true;
            Date_of_match = monthCalendar1.SelectionStart.ToShortDateString();
            Tab_ctrl.SelectTab(2);
        }

        private void Tab_ctrl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (New_stage)
            {
                New_stage = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void B_stage_3_1_Click(object sender, EventArgs e)
        {
            Program.validation = true;
            Program.checkParsing(Am_of_p1Box, ref team1.Am_of_pl, "Enter valid data");
            if (Program.validation && !Check_1.Visible)
            {
                AddPlayer frm = new AddPlayer(team1.Am_of_pl, team1);
                team1.Players = new Player[team1.Am_of_pl];
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Check_1.Visible = true;
            }
        }

        private void B_stage_3_2_Click(object sender, EventArgs e)
        {
            Program.validation = true;
            Program.checkParsing(Am_of_p2Box, ref team2.Am_of_pl, "Enter valid data");
            if (Program.validation && !Check_2.Visible)
            {
                AddPlayer frm = new AddPlayer(team2.Am_of_pl, team2);
                team2.Players = new Player[team2.Am_of_pl];
                this.Hide();
                frm.ShowDialog();
                this.Show();
                Check_2.Visible = true;
            }
        }

        private void B_stage_3_3_Click(object sender, EventArgs e)
        {
           if (Check_1.Visible == true && Check_2.Visible == true)
            {
                JSON_class j = new JSON_class(team1, team2, Date_of_match);
                j.writeJSON();
                this.Close();              
            }
        }

        private void ToAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
    
    
}
