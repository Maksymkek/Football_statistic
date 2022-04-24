
namespace Lab_4_S_A
{
    partial class ToViewers
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
            this.button1 = new System.Windows.Forms.Button();
            this.listOfMatchesBox = new System.Windows.Forms.ListBox();
            this.Team_nameBox = new System.Windows.Forms.TextBox();
            this.b_stage_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listPlView = new System.Windows.Forms.ListView();
            this.Col_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_goal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_timeOnF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_red_card = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_yel_card = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateMatch = new System.Windows.Forms.Label();
            this.Teams = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Режим перегляду ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 430);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.listOfMatchesBox);
            this.tabPage1.Controls.Add(this.Team_nameBox);
            this.tabPage1.Controls.Add(this.b_stage_1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Match searching";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Magenta;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(448, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 27);
            this.button1.TabIndex = 21;
            this.button1.TabStop = false;
            this.button1.Text = "Пошук матчів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfMatchesBox
            // 
            this.listOfMatchesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listOfMatchesBox.ForeColor = System.Drawing.Color.Snow;
            this.listOfMatchesBox.FormattingEnabled = true;
            this.listOfMatchesBox.ItemHeight = 20;
            this.listOfMatchesBox.Location = new System.Drawing.Point(29, 84);
            this.listOfMatchesBox.Name = "listOfMatchesBox";
            this.listOfMatchesBox.Size = new System.Drawing.Size(567, 224);
            this.listOfMatchesBox.TabIndex = 19;
            // 
            // Team_nameBox
            // 
            this.Team_nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Team_nameBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Team_nameBox.Location = new System.Drawing.Point(230, 52);
            this.Team_nameBox.Name = "Team_nameBox";
            this.Team_nameBox.Size = new System.Drawing.Size(200, 26);
            this.Team_nameBox.TabIndex = 18;
            // 
            // b_stage_1
            // 
            this.b_stage_1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.b_stage_1.FlatAppearance.BorderSize = 2;
            this.b_stage_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stage_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.b_stage_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_stage_1.Location = new System.Drawing.Point(241, 314);
            this.b_stage_1.Name = "b_stage_1";
            this.b_stage_1.Size = new System.Drawing.Size(147, 47);
            this.b_stage_1.TabIndex = 17;
            this.b_stage_1.TabStop = false;
            this.b_stage_1.Text = "Далі";
            this.b_stage_1.UseVisualStyleBackColor = true;
            this.b_stage_1.Click += new System.EventHandler(this.b_stage_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Уведіть команду: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listPlView);
            this.tabPage2.Controls.Add(this.DateMatch);
            this.tabPage2.Controls.Add(this.Teams);
            this.tabPage2.Controls.Add(this.b_save);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sorting players";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // listPlView
            // 
            this.listPlView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listPlView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_name,
            this.Col_goal,
            this.Col_timeOnF,
            this.Col_red_card,
            this.Col_yel_card});
            this.listPlView.ForeColor = System.Drawing.Color.Crimson;
            this.listPlView.FullRowSelect = true;
            this.listPlView.GridLines = true;
            this.listPlView.HideSelection = false;
            this.listPlView.Location = new System.Drawing.Point(57, 61);
            this.listPlView.Name = "listPlView";
            this.listPlView.Size = new System.Drawing.Size(514, 291);
            this.listPlView.TabIndex = 29;
            this.listPlView.UseCompatibleStateImageBehavior = false;
            this.listPlView.View = System.Windows.Forms.View.Details;
            this.listPlView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPlView_ColumnClick);
            // 
            // Col_name
            // 
            this.Col_name.Text = "Name";
            this.Col_name.Width = 160;
            // 
            // Col_goal
            // 
            this.Col_goal.Text = "Goals";
            // 
            // Col_timeOnF
            // 
            this.Col_timeOnF.Text = "Time";
            this.Col_timeOnF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_timeOnF.Width = 100;
            // 
            // Col_red_card
            // 
            this.Col_red_card.Text = "Red Cards";
            this.Col_red_card.Width = 100;
            // 
            // Col_yel_card
            // 
            this.Col_yel_card.Text = "Yel Cards";
            this.Col_yel_card.Width = 90;
            // 
            // DateMatch
            // 
            this.DateMatch.AutoSize = true;
            this.DateMatch.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateMatch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DateMatch.Location = new System.Drawing.Point(471, 11);
            this.DateMatch.Name = "DateMatch";
            this.DateMatch.Size = new System.Drawing.Size(115, 33);
            this.DateMatch.TabIndex = 25;
            this.DateMatch.Text = "??.??.????";
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teams.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Teams.Location = new System.Drawing.Point(49, 3);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(211, 44);
            this.Teams.TabIndex = 23;
            this.Teams.Text = "????? vs ?????";
            // 
            // b_save
            // 
            this.b_save.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.b_save.FlatAppearance.BorderSize = 2;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b_save.Location = new System.Drawing.Point(577, 61);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(30, 28);
            this.b_save.TabIndex = 17;
            this.b_save.TabStop = false;
            this.b_save.Text = "?";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(412, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designed by Maksym Hryschchenkov";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(577, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 28);
            this.button2.TabIndex = 30;
            this.button2.TabStop = false;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(577, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 29);
            this.button3.TabIndex = 31;
            this.button3.TabStop = false;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(577, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 29);
            this.button4.TabIndex = 32;
            this.button4.TabStop = false;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ToViewers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(660, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "ToViewers";
            this.Text = "ToViewers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToViewers_FormClosing);
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
        private System.Windows.Forms.Button b_stage_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label DateMatch;
        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.ListBox listOfMatchesBox;
        private System.Windows.Forms.TextBox Team_nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listPlView;
        private System.Windows.Forms.ColumnHeader Col_name;
        private System.Windows.Forms.ColumnHeader Col_goal;
        private System.Windows.Forms.ColumnHeader Col_timeOnF;
        private System.Windows.Forms.ColumnHeader Col_red_card;
        private System.Windows.Forms.ColumnHeader Col_yel_card;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}