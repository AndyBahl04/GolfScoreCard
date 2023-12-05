using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GolfScoreCard.Courses;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GolfScoreCard
{
    public partial class ScoreCard : Form
    {

        private string initialPlayerText = "Enter Your Name Here";
        private string initialHandicapText = "Enter Your Handicap Here";

        public ScoreCard()
        {

            InitializeComponent();
            NextHole.Visible = false;
            Par.Visible = false;
            HoleNumber.Visible = false;
            Yardage.Visible = false;
            HoleDifficulty.Visible = false;
            PlayerName.Text = initialPlayerText;
            PlayerName.Enter += PlayerName_Enter;
            Handicap.Text = initialHandicapText;
            Handicap.Enter += Handicap_Enter;
        }

        private void PlayerName_Enter(object sender, EventArgs e)
        {
            if (PlayerName.Text == initialPlayerText)
            {
                PlayerName.Text = "";
            }
        }

        private void Handicap_Enter(object sender, EventArgs e)
        {
            if (Handicap.Text == initialHandicapText)
            {
                Handicap.Text = "";
            }
        }
        

        private void NextHole_Click(object sender, EventArgs e)
        {

        }

        private void OliviaCourse_Click(object sender, EventArgs e)
        {
            NextHole.Visible = true;
            OliviaCourse.Visible = false;
            LakesGolfClub.Visible = false;
            StoneyCreek.Visible = false;
            BearsDen.Visible = false;
            GolfCourse.Text = "Olivia Golf Course";
            Par.Visible = true;
            HoleNumber.Visible = true;
            Yardage.Visible = true;
            HoleDifficulty.Visible = true;
        }

        private void LakesGolfClub_Click(object sender, EventArgs e)
        {
            NextHole.Visible = true;
            OliviaCourse.Visible = false;
            LakesGolfClub.Visible = false;
            StoneyCreek.Visible = false;
            BearsDen.Visible = false;
            GolfCourse.Text = "Lakes Golf Course";
            Par.Visible = true;
            HoleNumber.Visible = true;
            Yardage.Visible = true;
            HoleDifficulty.Visible = true;
        }

        private void StoneyCreek_Click(object sender, EventArgs e)
        {
            NextHole.Visible = true;
            OliviaCourse.Visible = false;
            LakesGolfClub.Visible = false;
            StoneyCreek.Visible = false;
            BearsDen.Visible = false;
            GolfCourse.Text = "StoneyCreek Golf Course";
            Par.Visible = true;
            HoleNumber.Visible = true;
            Yardage.Visible = true;
            HoleDifficulty.Visible = true;
        }

        private void BearsDen_Click(object sender, EventArgs e)
        {
            NextHole.Visible = true;
            OliviaCourse.Visible = false;
            LakesGolfClub.Visible = false;
            StoneyCreek.Visible = false;
            BearsDen.Visible = false;
            GolfCourse.Text = "Bears Den Golf Course";
            Par.Visible = true;
            HoleNumber.Visible = true;
            Yardage.Visible = true;
            HoleDifficulty.Visible = true;
        }
    }
}
