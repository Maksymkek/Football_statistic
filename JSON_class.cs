using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Lab_4_S_A
{
    public class Team_match
    {
        public Team team1;
        public Team team2;
    }
    public class JSON_class : Team
    {       
        public string Match_name;
        public string Date_of_match;
        public Team team1;
        public Team team2;
        public string filepath;
        Team_match mymatch = null;
        public JSON_class(Team team1,Team team2, string Date_of_match)
        {
            mymatch = new Team_match();
            this.team1 = mymatch.team1 = team1;
            this.team2 = mymatch.team2 = team2;
            //mymatch.Match_name = $"{team1.TName} vs {team2.TName}";
            filepath = $"Matches\\{team1.TName} vs {team2.TName} {Date_of_match}.json";
        }
        public JSON_class(Team_match team_match, string filepath)
        {
            mymatch = team_match;
            this.filepath = filepath;
        }
        public void writeJSON()
        {
            if (!Directory.Exists("Matches"))
            {
                Directory.CreateDirectory("Matches");
            }
            try {
                var json_write = JsonConvert.SerializeObject(mymatch, Formatting.Indented);
                using (var writer = new StreamWriter(filepath,false))
                {
                    writer.Write(json_write);
                } }
            catch(Exception ex)
            {
                MessageBox.Show($"Your data hasn't be saved:(\nclass:\t(JSON_class.cs)\n method:\t(void writeJSON())\n{ex.Message}", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static Team_match readJSON(string path)
        {
            try
            {
                string json_from_file;
                using (var reader = new StreamReader(path))
                {
                    json_from_file = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<Team_match>(json_from_file);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Your data hasn't be deserialized:(\nclass:\t(JSON_class.cs)\n method:\t(void readJSON())\n{ex.Message}", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
