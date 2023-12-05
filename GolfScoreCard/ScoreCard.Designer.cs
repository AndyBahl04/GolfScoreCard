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
            this.Par = new System.Windows.Forms.TextBox();
            this.Yardage = new System.Windows.Forms.TextBox();
            this.HoleNumber = new System.Windows.Forms.TextBox();
            this.HoleDifficulty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NextHole
            // 
            this.NextHole.Location = new System.Drawing.Point(945, 564);
            this.NextHole.Name = "NextHole";
            this.NextHole.Size = new System.Drawing.Size(96, 43);
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
            this.GolfCourse.Location = new System.Drawing.Point(438, 12);
            this.GolfCourse.Name = "GolfCourse";
            this.GolfCourse.Size = new System.Drawing.Size(199, 20);
            this.GolfCourse.TabIndex = 5;
            this.GolfCourse.Text = "Golf Scorecard App";
            this.GolfCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(169, 12);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(143, 20);
            this.PlayerName.TabIndex = 6;
            this.PlayerName.Text = "Enter Your Name Here";
            this.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Handicap
            // 
            this.Handicap.Location = new System.Drawing.Point(754, 12);
            this.Handicap.Name = "Handicap";
            this.Handicap.Size = new System.Drawing.Size(143, 20);
            this.Handicap.TabIndex = 8;
            this.Handicap.Text = "Enter Your Handicap Here";
            this.Handicap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Par
            // 
            this.Par.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Par.Location = new System.Drawing.Point(365, 77);
            this.Par.Name = "Par";
            this.Par.Size = new System.Drawing.Size(143, 45);
            this.Par.TabIndex = 9;
            // 
            // Yardage
            // 
            this.Yardage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Yardage.Location = new System.Drawing.Point(563, 77);
            this.Yardage.Name = "Yardage";
            this.Yardage.Size = new System.Drawing.Size(143, 45);
            this.Yardage.TabIndex = 10;
            // 
            // HoleNumber
            // 
            this.HoleNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.HoleNumber.Location = new System.Drawing.Point(169, 77);
            this.HoleNumber.Name = "HoleNumber";
            this.HoleNumber.Size = new System.Drawing.Size(143, 45);
            this.HoleNumber.TabIndex = 11;
            // 
            // HoleDifficulty
            // 
            this.HoleDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.HoleDifficulty.Location = new System.Drawing.Point(754, 77);
            this.HoleDifficulty.Name = "HoleDifficulty";
            this.HoleDifficulty.Size = new System.Drawing.Size(143, 45);
            this.HoleDifficulty.TabIndex = 12;
            // 
            // ScoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1053, 633);
            this.Controls.Add(this.HoleDifficulty);
            this.Controls.Add(this.HoleNumber);
            this.Controls.Add(this.Yardage);
            this.Controls.Add(this.Par);
            this.Controls.Add(this.Handicap);
            this.Controls.Add(this.PlayerName);
            this.Controls.Add(this.GolfCourse);
            this.Controls.Add(this.BearsDen);
            this.Controls.Add(this.StoneyCreek);
            this.Controls.Add(this.LakesGolfClub);
            this.Controls.Add(this.OliviaCourse);
            this.Controls.Add(this.NextHole);
            this.Name = "ScoreCard";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox Par;
        private System.Windows.Forms.TextBox Yardage;
        private System.Windows.Forms.TextBox HoleNumber;
        private System.Windows.Forms.TextBox HoleDifficulty;
    }
}

