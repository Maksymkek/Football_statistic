
namespace Lab_4_S_A
{
    partial class ToRedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.b_stage_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Team2_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Team1_box = new System.Windows.Forms.TextBox();
            this.vs = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DateMatch = new System.Windows.Forms.Label();
            this.MaxId = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.P_idBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GoalBox1 = new System.Windows.Forms.TextBox();
            this.b_red_p = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TNumBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GoalBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Режим редагування";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 291);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tabPage1.Controls.Add(this.b_stage_1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.Team2_box);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Team1_box);
            this.tabPage1.Controls.Add(this.vs);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Match";
            // 
            // b_stage_1
            // 
            this.b_stage_1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.b_stage_1.FlatAppearance.BorderSize = 2;
            this.b_stage_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stage_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_stage_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_stage_1.Location = new System.Drawing.Point(185, 186);
            this.b_stage_1.Name = "b_stage_1";
            this.b_stage_1.Size = new System.Drawing.Size(159, 43);
            this.b_stage_1.TabIndex = 17;
            this.b_stage_1.TabStop = false;
            this.b_stage_1.Text = "Далі";
            this.b_stage_1.UseVisualStyleBackColor = true;
            this.b_stage_1.Click += new System.EventHandler(this.b_stage_1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(153, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Уведіть дату матчу:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Team2_box
            // 
            this.Team2_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Team2_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Team2_box.Location = new System.Drawing.Point(303, 62);
            this.Team2_box.Name = "Team2_box";
            this.Team2_box.Size = new System.Drawing.Size(200, 26);
            this.Team2_box.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(163, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Уведіть команди: ";
            // 
            // Team1_box
            // 
            this.Team1_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Team1_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Team1_box.Location = new System.Drawing.Point(24, 62);
            this.Team1_box.Name = "Team1_box";
            this.Team1_box.Size = new System.Drawing.Size(200, 26);
            this.Team1_box.TabIndex = 7;
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.vs.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vs.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vs.Location = new System.Drawing.Point(240, 38);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(57, 57);
            this.vs.TabIndex = 9;
            this.vs.Text = "vs";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.DateMatch);
            this.tabPage2.Controls.Add(this.MaxId);
            this.tabPage2.Controls.Add(this.Teams);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.P_idBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.GoalBox1);
            this.tabPage2.Controls.Add(this.b_red_p);
            this.tabPage2.Controls.Add(this.b_save);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TNumBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.GoalBox);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New params";
            // 
            // DateMatch
            // 
            this.DateMatch.AutoSize = true;
            this.DateMatch.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateMatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateMatch.Location = new System.Drawing.Point(142, 50);
            this.DateMatch.Name = "DateMatch";
            this.DateMatch.Size = new System.Drawing.Size(93, 33);
            this.DateMatch.TabIndex = 25;
            this.DateMatch.Text = "??.??.??";
            // 
            // MaxId
            // 
            this.MaxId.AutoSize = true;
            this.MaxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxId.ForeColor = System.Drawing.Color.Red;
            this.MaxId.Location = new System.Drawing.Point(313, 164);
            this.MaxId.Name = "MaxId";
            this.MaxId.Size = new System.Drawing.Size(63, 20);
            this.MaxId.TabIndex = 24;
            this.MaxId.Text = "Max: --";
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teams.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Teams.Location = new System.Drawing.Point(41, 3);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(211, 44);
            this.Teams.TabIndex = 23;
            this.Teams.Text = "????? vs ?????";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(22, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Змінити дані гравця під №";
            // 
            // P_idBox
            // 
            this.P_idBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.P_idBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.P_idBox.Location = new System.Drawing.Point(390, 161);
            this.P_idBox.Name = "P_idBox";
            this.P_idBox.Size = new System.Drawing.Size(34, 26);
            this.P_idBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(430, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "::";
            // 
            // GoalBox1
            // 
            this.GoalBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.GoalBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GoalBox1.Location = new System.Drawing.Point(474, 84);
            this.GoalBox1.Name = "GoalBox1";
            this.GoalBox1.Size = new System.Drawing.Size(34, 26);
            this.GoalBox1.TabIndex = 19;
            // 
            // b_red_p
            // 
            this.b_red_p.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.b_red_p.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_red_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_red_p.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_red_p.Location = new System.Drawing.Point(429, 161);
            this.b_red_p.Name = "b_red_p";
            this.b_red_p.Size = new System.Drawing.Size(106, 26);
            this.b_red_p.TabIndex = 18;
            this.b_red_p.TabStop = false;
            this.b_red_p.Text = "Редагувати";
            this.b_red_p.UseVisualStyleBackColor = true;
            this.b_red_p.Click += new System.EventHandler(this.b_red_p_Click);
            // 
            // b_save
            // 
            this.b_save.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.b_save.FlatAppearance.BorderSize = 2;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_save.Location = new System.Drawing.Point(191, 200);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(159, 43);
            this.b_save.TabIndex = 17;
            this.b_save.TabStop = false;
            this.b_save.Text = "Зберегти";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(22, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Змінити дані гравця команди №";
            // 
            // TNumBox1
            // 
            this.TNumBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.TNumBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TNumBox1.Location = new System.Drawing.Point(390, 122);
            this.TNumBox1.Name = "TNumBox1";
            this.TNumBox1.Size = new System.Drawing.Size(34, 26);
            this.TNumBox1.TabIndex = 14;
            this.TNumBox1.TextChanged += new System.EventHandler(this.TNumBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Змінити кількість забитих голів:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GoalBox
            // 
            this.GoalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.GoalBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GoalBox.Location = new System.Drawing.Point(390, 84);
            this.GoalBox.Name = "GoalBox";
            this.GoalBox.Size = new System.Drawing.Size(34, 26);
            this.GoalBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(325, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Designed by Maksym Hryschchenkov";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(356, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Збережено";
            this.label9.Visible = false;
            // 
            // ToRedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(573, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "ToRedForm";
            this.Text = "ToRedForm";
            this.Deactivate += new System.EventHandler(this.ToRedForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToRedForm_FormClosing_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Team2_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.TextBox Team1_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button b_stage_1;
        private System.Windows.Forms.TextBox GoalBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TNumBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_red_p;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.TextBox GoalBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox P_idBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Label MaxId;
        private System.Windows.Forms.Label DateMatch;
        private System.Windows.Forms.Label label9;
    }
}