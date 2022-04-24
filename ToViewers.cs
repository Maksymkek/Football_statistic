using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_4_S_A
{
    public partial class ToViewers : Form
    {
        string Team_name;
        Team_match match;
        bool New_stage = false;
        int selected_team;
        bool Team_added = false;
        List<Player> sort_pl = new List<Player>();
        Team sel_team;
        List<Player> pl_to_show = new List<Player>();
        bool ToReverse = false;
        int last_clicked_col;
        public ToViewers()
        {
            InitializeComponent();            
        }
        void To_sort(int sortingColIndex)
        {
            if (sortingColIndex!=0)
            {
                bool added = false;
                foreach (var pl in pl_to_show)
                {
                    if(sort_pl.Count > 0)
                    {
                        foreach (var s_pl in sort_pl)
                        {
                            if(pl.PGoal >= s_pl.PGoal && sortingColIndex == 1)
                            {
                                sort_pl.Insert(sort_pl.IndexOf(s_pl), pl);                                
                                added = true;
                                break;
                            }
                            else if(pl.PRedCards >= s_pl.PRedCards && sortingColIndex == 3)
                            {
                                sort_pl.Insert(sort_pl.IndexOf(s_pl), pl);
                                added = true;
                                break;
                            }
                            else if(pl.PYellowCards >= s_pl.PYellowCards && sortingColIndex == 4)
                            {
                                sort_pl.Insert(sort_pl.IndexOf(s_pl), pl);
                                added = true;
                                break;
                            }
                            else if(sortingColIndex == 2)
                            {
                                DateTime tmp = DateTime.Now;
                                DateTime tmp1 = DateTime.Now;
                                if (Program.checkParsing(pl.PTimeOnField,ref tmp) && Program.checkParsing(s_pl.PTimeOnField,ref tmp1))
                                {
                                    if (tmp >= tmp1)
                                    {
                                        sort_pl.Insert(sort_pl.IndexOf(s_pl), pl);
                                        added = true;
                                        break;
                                    }
                                }
                            }
                        }
                        if (!added)
                        {
                            sort_pl.Add(pl);
                        }
                    }
                    else
                    { 
                        sort_pl.Add(pl);
                    }
                    added = false;
                }
            }
            To_out_in_list();
        }
        void To_out_in_list()
        {
            listPlView.Items.Clear();
            if (ToReverse)
            {
                sort_pl.Reverse();
            }
            foreach (var player in sort_pl)
            {
                ListViewItem pl = new ListViewItem(player.PName);
                pl.SubItems.Add(player.PGoal.ToString());
                pl.SubItems.Add(player.PTimeOnField);
                pl.SubItems.Add(player.PRedCards.ToString());
                pl.SubItems.Add(player.PYellowCards.ToString());
                listPlView.Items.Add(pl);
            }
            sort_pl.Clear();

        }
        void To_fill_listView()
        {
            try
            {
                foreach (var player in pl_to_show)
                {
                    ListViewItem pl = new ListViewItem(player.PName);
                    pl.SubItems.Add(player.PGoal.ToString());
                    pl.SubItems.Add(player.PTimeOnField);
                    pl.SubItems.Add(player.PRedCards.ToString());
                    pl.SubItems.Add(player.PYellowCards.ToString());
                    listPlView.Items.Add(pl);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Not all matches added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listOfMatchesBox.Items.Clear();
            Team_name = Team_nameBox.Text;
            if (Directory.Exists("Matches"))
            {
                string [] all_names = Directory.GetFiles("Matches");
                foreach(var item in all_names)
                {
                    if(item.Contains(Team_name))
                    {
                        listOfMatchesBox.Items.Add(item.Replace("Matches\\","").Replace(".json",""));
                    }
                }
            }
            else
            {
                MessageBox.Show("No matches added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_stage_1_Click(object sender, EventArgs e)
        {
            if (listOfMatchesBox.SelectedItems.Count > 0)
            {
                string selected_match = $"Matches\\{(string)listOfMatchesBox.SelectedItem}.json";
                match = JSON_class.readJSON(selected_match);
                New_stage = true;
                Teams.Text = match.team1.TName + " vs " + match.team2.TName;
                DateMatch.Text = listOfMatchesBox.SelectedItem.ToString().Replace(Teams.Text, "");
                selected_team = 2;
                if(match.team1.TName.Contains(Team_nameBox.Text))
                {
                    selected_team = 1;
                }
                tabControl1.SelectTab(1);
            }
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

        private void ToViewers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {

            sel_team = match.team2;
            if (selected_team == 1)
            {
                sel_team = match.team1;
            }
            pl_to_show = sel_team.Players.ToList();
            To_fill_listView();
        }

        private void listPlView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column == last_clicked_col)
            {
                if (!ToReverse)
                {
                    ToReverse = true;
                }
                else
                {
                    ToReverse = false;
                }
            }
            try
            {
                To_sort(e.Column);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            last_clicked_col = e.Column;
        }
        private void b_save_Click(object sender, EventArgs e)
        {
            string Message = $"Current team:\t\nTips:\tTo sorting:  tap on column name\n" +
                $"     \tTo back:  tap on red button\n" +
                $"     \tTo add or sub players:  tap on +/-";
            Message = Team_added ? Message.Insert(14, $"{match.team1.TName} , {match.team2.TName}") : Message.Insert(14, $"{sel_team.TName}");
            MessageBox.Show(Message, "Reference", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_stage = true;
            listPlView.Items.Clear();
            tabControl1.SelectTab(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Team_added = true;
            pl_to_show.Clear();
            listPlView.Items.Clear();
            foreach (var pl in match.team1.Players)
            {
                pl_to_show.Add(pl);
            }
            foreach (var pl in match.team2.Players)
            {
                pl_to_show.Add(pl);
            }
            To_fill_listView();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Team_added = false;
            pl_to_show.Clear();
            listPlView.Items.Clear();
            foreach(var pl in sel_team.Players)
            {
                pl_to_show.Add(pl);
            }
            To_fill_listView();
        }
    }
}
