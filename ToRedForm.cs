using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace Lab_4_S_A
{
    public partial class ToRedForm : Form
    {
        Team_match team_Match;
        string file_to_red;
        int id_p;
        int team_num;
        string[] all_filenames;
        public ToRedForm()
        {
            InitializeComponent();
        }
        private bool New_stage = false;
        
        
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
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

        private void b_stage_1_Click(object sender, EventArgs e)
        {
            file_to_red = $"Matches\\{Team1_box.Text} vs {Team2_box.Text} {dateTimePicker1.Value.ToShortDateString()}.json";
            if (Directory.Exists("Matches"))
            {
                all_filenames = Directory.GetFiles("Matches");
                foreach(var item in all_filenames)
                {
                    if (file_to_red == item)
                    {
                        team_Match = JSON_class.readJSON(file_to_red);
                        New_stage = true;
                        Teams.Text = $"{Team1_box.Text} vs {Team2_box.Text}";
                        DateMatch.Text = $"{dateTimePicker1.Value.ToShortDateString()}";
                        tabControl1.SelectTab(1);
                    }
                }                
            }           
        }

        private void ToRedForm_Deactivate(object sender, EventArgs e)
        {            
           
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            Program.validation = true;
            Program.checkParsing(GoalBox, ref team_Match.team1.TScore,0, 99, "Out of range");
            Program.checkParsing(GoalBox1, ref team_Match.team2.TScore, 0, 99, "Out of range");
            if (Program.validation)
            {
                JSON_class j = new JSON_class(team_Match, file_to_red);
                j.writeJSON();
                label9.Visible = true;
            }
        }

        private void b_red_p_Click(object sender, EventArgs e)
        {
            Program.validation = true;
            Program.checkParsing(TNumBox1, ref team_num, 1, 2, "NaN");
            Program.checkParsing(P_idBox, ref id_p, 1, team_Match.team1.Am_of_pl, "NaN");
            if (Program.validation)
            {
                if (team_num == 1)
                {
                    AddPlayer p = new AddPlayer(id_p, team_Match.team1.Players);
                    p.Show();
                }
                else
                {
                    AddPlayer p = new AddPlayer(id_p, team_Match.team2.Players);
                    p.Show();
                }
            }
        }

        private void ToRedForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void TNumBox1_TextChanged(object sender, EventArgs e)
        {
            Program.checkParsing(TNumBox1, ref team_num, 1, 2, "NaN");
            if (team_num == 1)
            {
                MaxId.Text = $"Max:{team_Match.team1.Am_of_pl}";
            }
            else if (team_num == 2)
            {
                MaxId.Text = $"Max:{team_Match.team2.Am_of_pl}";
            }
        }
    }
}
