namespace GolfScoreCard
{
    partial class ScoreCard
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
            this.components = new System.ComponentModel.Container();
            this.NextHole = new System.Windows.Forms.Button();
            this.OliviaCourse = new System.Windows.Forms.Button();
            this.LakesGolfClub = new System.Windows.Forms.Button();
            this.StoneyCreek = new System.Windows.Forms.Button();
            this.BearsDen = new System.Windows.Forms.Button();
            this.GolfCourse = new System.Windows.Forms.TextBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Handicap = new System.Windows.Forms.TextBox();
            this.HoleImage = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.TextBox();
            this.HoleNumber = new System.Windows.Forms.Label();
            this.Par = new System.Windows.Forms.Label();
            this.Yardage = new System.Windows.Forms.Label();
            this.HoleDifficulty = new System.Windows.Forms.Label();
            this.FinalScore = new System.Windows.Forms.Label();
            this.UpdatedHandicap = new System.Windows.Forms.Label();
            this.HistoryPlayer = new System.Windows.Forms.Label();
            this.HistoryScore = new System.Windows.Forms.Label();
            this.Weather = new System.Windows.Forms.TextBox();
            this.Temp = new System.Windows.Forms.Label();
            this.Wind = new System.Windows.Forms.Label();
            this.EnterScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HoleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NextHole
            // 
            this.NextHole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NextHole.Location = new System.Drawing.Point(923, 558);
            this.NextHole.Name = "NextHole";
            this.NextHole.Size = new System.Drawing.Size(118, 49);
            this.NextHole.TabIndex = 0;
            this.NextHole.Text = "Next Hole";
            this.NextHole.UseVisualStyleBackColor = true;
            this.NextHole.Click += new System.EventHandler(this.NextHole_Click);
            // 
            // OliviaCourse
            // 
            this.OliviaCourse.Location = new System.Drawing.Point(169, 77);
            this.OliviaCourse.Name = "OliviaCourse";
            this.OliviaCourse.Size = new System.Drawing.Size(143, 36);
            this.OliviaCourse.TabIndex = 1;
            this.OliviaCourse.Text = "Olivia Golf Course";
            this.OliviaCourse.UseVisualStyleBackColor = true;
            this.OliviaCourse.Click += new System.EventHandler(this.OliviaCourse_Click);
            // 
            // LakesGolfClub
            // 
            this.LakesGolfClub.Location = new System.Drawing.Point(365, 77);
            this.LakesGolfClub.Name = "LakesGolfClub";
            this.LakesGolfClub.Size = new System.Drawing.Size(143, 36);
            this.LakesGolfClub.TabIndex = 2;
            this.LakesGolfClub.Text = "Lakes Golf Course";
            this.LakesGolfClub.UseVisualStyleBackColor = true;
            this.LakesGolfClub.Click += new System.EventHandler(this.LakesGolfClub_Click);
            // 
            // StoneyCreek
            // 
            this.StoneyCreek.Location = new System.Drawing.Point(563, 77);
            this.StoneyCreek.Name = "StoneyCreek";
            this.StoneyCreek.Size = new System.Drawing.Size(143, 36);
            this.StoneyCreek.TabIndex = 3;
            this.StoneyCreek.Text = "StoneyCreek Golf Course";
            this.StoneyCreek.UseVisualStyleBackColor = true;
            this.StoneyCreek.Click += new System.EventHandler(this.StoneyCreek_Click);
            // 
            // BearsDen
            // 
            this.BearsDen.Location = new System.Drawing.Point(754, 77);
            this.BearsDen.Name = "BearsDen";
            this.BearsDen.Size = new System.Drawing.Size(143, 36);
            this.BearsDen.TabIndex = 4;
            this.BearsDen.Text = "Bears Den Golf Course";
            this.BearsDen.UseVisualStyleBackColor = true;
            this.BearsDen.Click += new System.EventHandler(this.BearsDen_Click);
            // 
            // GolfCourse
            // 
            this.GolfCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GolfCourse.Location = new System.Drawing.Point(438, 12);
            this.GolfCourse.Name = "GolfCourse";
            this.GolfCourse.Size = new System.Drawing.Size(199, 26);
            this.GolfCourse.TabIndex = 5;
            this.GolfCourse.Text = "Golf Scorecard App";
            this.GolfCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerName
            // 
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlayerName.Location = new System.Drawing.Point(161, 12);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(151, 26);
            this.PlayerName.TabIndex = 6;
            this.PlayerName.Text = "Enter Your Name";
            this.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Handicap
            // 
            this.Handicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Handicap.Location = new System.Drawing.Point(754, 12);
            this.Handicap.Name = "Handicap";
            this.Handicap.Size = new System.Drawing.Size(143, 24);
            this.Handicap.TabIndex = 8;
            this.Handicap.Text = "Enter Your Handicap";
            this.Handicap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoleImage
            // 
            this.HoleImage.Location = new System.Drawing.Point(416, 128);
            this.HoleImage.Name = "HoleImage";
            this.HoleImage.Size = new System.Drawing.Size(234, 380);
            this.HoleImage.TabIndex = 13;
            this.HoleImage.TabStop = false;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Score.Location = new System.Drawing.Point(416, 562);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(234, 45);
            this.Score.TabIndex = 14;
            this.Score.Text = "Enter Score";
            this.Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoleNumber
            // 
            this.HoleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HoleNumber.Location = new System.Drawing.Point(156, 77);
            this.HoleNumber.Name = "HoleNumber";
            this.HoleNumber.Size = new System.Drawing.Size(156, 45);
            this.HoleNumber.TabIndex = 17;
            this.HoleNumber.Text = "HoleNumber";
            this.HoleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Par
            // 
            this.Par.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Par.Location = new System.Drawing.Point(362, 77);
            this.Par.Name = "Par";
            this.Par.Size = new System.Drawing.Size(146, 45);
            this.Par.TabIndex = 18;
            this.Par.Text = "Par";
            this.Par.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Yardage
            // 
            this.Yardage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Yardage.Location = new System.Drawing.Point(563, 77);
            this.Yardage.Name = "Yardage";
            this.Yardage.Size = new System.Drawing.Size(143, 45);
            this.Yardage.TabIndex = 19;
            this.Yardage.Text = "Yardage";
            this.Yardage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoleDifficulty
            // 
            this.HoleDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.HoleDifficulty.Location = new System.Drawing.Point(754, 77);
            this.HoleDifficulty.Name = "HoleDifficulty";
            this.HoleDifficulty.Size = new System.Drawing.Size(143, 45);
            this.HoleDifficulty.TabIndex = 20;
            this.HoleDifficulty.Text = "HoleDifficulty";
            this.HoleDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinalScore
            // 
            this.FinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.FinalScore.Location = new System.Drawing.Point(17, 211);
            this.FinalScore.Name = "FinalScore";
            this.FinalScore.Size = new System.Drawing.Size(532, 116);
            this.FinalScore.TabIndex = 21;
            this.FinalScore.Text = "FinalScore";
            this.FinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdatedHandicap
            // 
            this.UpdatedHandicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.UpdatedHandicap.Location = new System.Drawing.Point(560, 211);
            this.UpdatedHandicap.Name = "UpdatedHandicap";
            this.UpdatedHandicap.Size = new System.Drawing.Size(481, 116);
            this.UpdatedHandicap.TabIndex = 22;
            this.UpdatedHandicap.Text = "UpdatedHandicap";
            this.UpdatedHandicap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryPlayer
            // 
            this.HistoryPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.HistoryPlayer.Location = new System.Drawing.Point(17, 211);
            this.HistoryPlayer.Name = "HistoryPlayer";
            this.HistoryPlayer.Size = new System.Drawing.Size(532, 116);
            this.HistoryPlayer.TabIndex = 23;
            this.HistoryPlayer.Text = "HistoryPlayer";
            this.HistoryPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryScore
            // 
            this.HistoryScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.HistoryScore.Location = new System.Drawing.Point(560, 211);
            this.HistoryScore.Name = "HistoryScore";
            this.HistoryScore.Size = new System.Drawing.Size(481, 116);
            this.HistoryScore.TabIndex = 24;
            this.HistoryScore.Text = "HistoryScore";
            this.HistoryScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Weather
            // 
            this.Weather.Location = new System.Drawing.Point(3, 601);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(100, 20);
            this.Weather.TabIndex = 25;
            // 
            // Temp
            // 
            this.Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Temp.Location = new System.Drawing.Point(12, 299);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(202, 45);
            this.Temp.TabIndex = 26;
            this.Temp.Text = "Temp";
            this.Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wind
            // 
            this.Wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Wind.Location = new System.Drawing.Point(-2, 344);
            this.Wind.Name = "Wind";
            this.Wind.Size = new System.Drawing.Size(216, 45);
            this.Wind.TabIndex = 27;
            this.Wind.Text = "Wind";
            this.Wind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterScore
            // 
            this.EnterScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EnterScore.Location = new System.Drawing.Point(416, 511);
            this.EnterScore.Name = "EnterScore";
            this.EnterScore.Size = new System.Drawing.Size(234, 41);
            this.EnterScore.TabIndex = 28;
            this.EnterScore.Text = "Enter Score Below";
            this.EnterScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1053, 633);
            this.Controls.Add(this.EnterScore);
            this.Controls.Add(this.Wind);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Weather);
            this.Controls.Add(this.HistoryScore);
            this.Controls.Add(this.HistoryPlayer);
            this.Controls.Add(this.UpdatedHandicap);
            this.Controls.Add(this.FinalScore);
            this.Controls.Add(this.HoleDifficulty);
            this.Controls.Add(this.Yardage);
            this.Controls.Add(this.Par);
            this.Controls.Add(this.HoleNumber);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.HoleImage);
            this.Controls.Add(this.Handicap);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.GolfCourse);
            this.Controls.Add(this.BearsDen);
            this.Controls.Add(this.StoneyCreek);
            this.Controls.Add(this.LakesGolfClub);
            this.Controls.Add(this.OliviaCourse);
            this.Controls.Add(this.NextHole);
            this.Name = "ScoreCard";
            this.Text = "ScoreCard";
            ((System.ComponentModel.ISupportInitialize)(this.HoleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextHole;
        private System.Windows.Forms.Button OliviaCourse;
        private System.Windows.Forms.Button LakesGolfClub;
        private System.Windows.Forms.Button StoneyCreek;
        private System.Windows.Forms.Button BearsDen;
        private System.Windows.Forms.TextBox GolfCourse;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Handicap;
        private System.Windows.Forms.PictureBox HoleImage;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.Label HoleNumber;
        private System.Windows.Forms.Label Par;
        private System.Windows.Forms.Label Yardage;
        private System.Windows.Forms.Label HoleDifficulty;
        private System.Windows.Forms.Label FinalScore;
        private System.Windows.Forms.Label UpdatedHandicap;
        private System.Windows.Forms.Label HistoryPlayer;
        private System.Windows.Forms.Label HistoryScore;
        private System.Windows.Forms.TextBox Weather;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Label Wind;
        private System.Windows.Forms.Label EnterScore;
    }
}

