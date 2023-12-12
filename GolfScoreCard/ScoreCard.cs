using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GolfScoreCard.Courses;
using static GolfScoreCard.Weather;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GolfScoreCard
{
    public partial class ScoreCard : Form
    {

        #region Private Method Calls
        private string playerText = "Enter Your Name";
        private string handicapText = "Enter Your Handicap";
        private string scoreText = "EnterScore";
        private Courses.Course course;
        private Calculations calc;
        private int currentHole = 0;
        WeatherApi weatherApi = new WeatherApi();
        private List<int> scoresList = new List<int>();
        #endregion

        public ScoreCard()
        {
            InitializeComponent();

            #region Visibility
            course = new Courses.Course();
            calc = new Calculations();
            NextHole.Visible = false;
            Par.Visible = false;
            HoleNumber.Visible = false;
            Yardage.Visible = false;
            HoleDifficulty.Visible = false;
            Score.Visible = false;
            HoleImage.Visible = false;
            FinalScore.Visible = false;
            UpdatedHandicap.Visible = false;
            Weather.Visible = false;
            Temp.Visible = false;
            Wind.Visible = false;
            EnterScore.Visible = false;
            exit.Visible = false;
            #endregion

            #region Enter Methods Calls
            PlayerName.Text = playerText;
            PlayerName.Enter += PlayerName_Enter;
            Handicap.Text = handicapText;
            Handicap.Enter += Handicap_Enter;
            Score.Text = scoreText;
            Score.Enter += Score_Enter;
            #endregion

            #region History Load
            List<History.HistoryEntry> userHistory = History.PlayerHistory.LoadUserScores();
            foreach (var entry in userHistory)
            {
                HistoryPlayer.Text = $"Recent Player: {entry.PlayerName}";
                HistoryScore.Text = $"Recent Score: {entry.Score.ToString()}";
            }
            #endregion
        }

        #region Enter Methods
        private void PlayerName_Enter(object sender, EventArgs e)
        {
            if (PlayerName.Text == playerText)
            {
                PlayerName.Text = "";
            }
        }

        private void Handicap_Enter(object sender, EventArgs e)
        {
            if (Handicap.Text == handicapText)
            {
                Handicap.Text = "";
            }
        }
        private void Score_Enter(object sender, EventArgs e)
        {
            if (Score.Text == scoreText)
            {
                Score.Text = "";
            }
        }
        #endregion

        private void NextHole_Click(object sender, EventArgs e)
        {
            #region Next Hole Updates
            if (currentHole < course.Holes.Count)
            {
                NextHole.Text = "Next Hole";
                Score.Visible = true;
                EnterScore.Visible = true;
                UpdateLabels();

                if (int.TryParse(Score.Text, out int score))
                {
                    scoresList.Add(score);
                }
                Score.Clear();

                currentHole++;
            }
            else
            {
                MessageBox.Show("You've reached the end of the course!");
            }
            #endregion

            #region Final Score
            if (scoresList.Count == 9)
            {
                int finalScore = calc.FinalScore(scoresList);

                if (double.TryParse(Handicap.Text, out double handicap))
                {
                    double updatedHandicap = calc.UpdateHandicap(finalScore, handicap);
                    string playerName = PlayerName.Text;

                    FinalScore.Visible = true;
                    UpdatedHandicap.Visible = true;
                    NextHole.Visible = false;
                    Par.Visible = false;
                    HoleNumber.Visible = false;
                    Yardage.Visible = false;
                    HoleDifficulty.Visible = false;
                    Score.Visible = false;
                    HoleImage.Visible = false;
                    Weather.Visible = false;
                    Temp.Visible = false;
                    Wind.Visible = false;
                    EnterScore.Visible = false;
                    exit.Visible = true;
                    FinalScore.Text = $"Final Score: {finalScore}";
                    UpdatedHandicap.Text = $"Updated Handicap: {updatedHandicap}";
                    History.PlayerHistory.SaveUserScore(playerName, finalScore);
                }
                else
                {
                    MessageBox.Show("Please enter a valid handicap.");
                }
            }
            #endregion
        }

        private void OliviaCourse_Click(object sender, EventArgs e)
        {
            #region TextBox Changes
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
            HoleImage.Visible = true;
            HistoryPlayer.Visible = false;
            HistoryScore.Visible = false;
            Temp.Visible = true;
            Wind.Visible = true;
            Weather.Text = "56277";
            NextHole.Text = "Start";
            #endregion

            #region Olivia Holes
            course.AddHole(1, 5, 501, 5, Path.Combine("images", "OliviaHole1.jpg"));
            course.AddHole(2, 3, 208, 3, Path.Combine("images", "OliviaHole2.jpg"));
            course.AddHole(3, 4, 383, 2, Path.Combine("images", "OliviaHole3.jpg"));
            course.AddHole(4, 4, 349, 7, Path.Combine("images", "OliviaHole4.jpg"));
            course.AddHole(5, 3, 145, 9, Path.Combine("images", "OliviaHole5.jpg"));
            course.AddHole(6, 4, 406, 1, Path.Combine("images", "OliviaHole6.jpg"));
            course.AddHole(7, 4, 362, 6, Path.Combine("images", "OliviaHole7.jpg"));
            course.AddHole(8, 5, 512, 4, Path.Combine("images", "OliviaHole8.jpg"));
            course.AddHole(9, 4, 305, 8, Path.Combine("images", "OliviaHole9.jpg"));
            course.AddHole(0, 0, 0, 0, Path.Combine("images", "Final.jpg"));
            #endregion
            
            btnGetWeather_Click();
        }

        private void LakesGolfClub_Click(object sender, EventArgs e)
        {
            #region TextBox Changes
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
            HoleImage.Visible = true;
            HistoryPlayer.Visible = false;
            HistoryScore.Visible = false;
            Temp.Visible = true;
            Wind.Visible = true;
            Weather.Text = "57075";
            NextHole.Text = "Start";
            #endregion

            #region Lakes Holes
            course.AddHole(1, 5, 505, 1, Path.Combine("images", "LakesHole1.jpg"));
            course.AddHole(2, 3, 168, 7, Path.Combine("images", "LakesHole2.jpg"));
            course.AddHole(3, 4, 270, 3, Path.Combine("images", "LakesHole3.jpg"));
            course.AddHole(4, 4, 346, 6, Path.Combine("images", "LakesHole4.jpg"));
            course.AddHole(5, 4, 319, 8, Path.Combine("images", "LakesHole5.jpg"));
            course.AddHole(6, 4, 265, 2, Path.Combine("images", "LakesHole6.jpg"));
            course.AddHole(7, 3, 169, 5, Path.Combine("images", "LakesHole7.jpg"));
            course.AddHole(8, 4, 309, 4, Path.Combine("images", "LakesHole8.jpg"));
            course.AddHole(9, 5, 463, 9, Path.Combine("images", "LakesHole9.jpg"));
            course.AddHole(0, 0, 0, 0, Path.Combine("images", "Final.jpg"));
            #endregion 

            btnGetWeather_Click();
        }

        private void StoneyCreek_Click(object sender, EventArgs e)
        {
            #region TextBox Changes
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
            HoleImage.Visible = true;
            HistoryPlayer.Visible = false;
            HistoryScore.Visible = false;
            Temp.Visible = true;
            Wind.Visible = true;
            Weather.Text = "56284";
            NextHole.Text = "Start";
            #endregion

            #region Stoney Creek Holes
            course.AddHole(1, 5, 555, 0, Path.Combine("images", "StoneyHole1.jpg"));
            course.AddHole(2, 4, 432, 0, Path.Combine("images", "StoneyHole2.jpg"));
            course.AddHole(3, 3, 234, 0, Path.Combine("images", "StoneyHole3.jpg"));
            course.AddHole(4, 5, 550, 0, Path.Combine("images", "StoneyHole4.jpg"));
            course.AddHole(5, 4, 381, 0, Path.Combine("images", "StoneyHole5.jpg"));
            course.AddHole(6, 4, 363, 0, Path.Combine("images", "StoneyHole6.jpg"));
            course.AddHole(7, 3, 178, 0, Path.Combine("images", "StoneyHole7.jpg"));
            course.AddHole(8, 4, 372, 0, Path.Combine("images", "StoneyHole8.jpg"));
            course.AddHole(9, 4, 373, 0, Path.Combine("images", "StoneyHole9.jpg"));
            course.AddHole(0, 0, 0, 0, Path.Combine("images", "Final.jpg"));
            #endregion

            btnGetWeather_Click();
        }

        private void BearsDen_Click(object sender, EventArgs e)
        {
            #region TextBox Changes
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
            HoleImage.Visible = true;
            HistoryPlayer.Visible = false;
            HistoryScore.Visible = false;
            Temp.Visible = true;
            Wind.Visible = true;
            Weather.Text = "56470";
            NextHole.Text = "Start";
            #endregion

            #region Bears Den Holes
            course.AddHole(1, 4, 333, 0, Path.Combine("images", "BearsHole1.jpg"));
            course.AddHole(2, 4, 359, 0, Path.Combine("images", "BearsHole2.jpg"));
            course.AddHole(3, 4, 301, 0, Path.Combine("images", "BearsHole3.jpg"));
            course.AddHole(4, 3, 209, 0, Path.Combine("images", "BearsHole4.jpg"));
            course.AddHole(5, 5, 470, 0, Path.Combine("images", "BearsHole5.jpg"));
            course.AddHole(6, 3, 158, 0, Path.Combine("images", "BearsHole6.jpg"));
            course.AddHole(7, 4, 278, 0, Path.Combine("images", "BearsHole7.jpg"));
            course.AddHole(8, 4, 431, 0, Path.Combine("images", "BearsHole8.jpg"));
            course.AddHole(9, 5, 470, 0, Path.Combine("images", "BearsHole9.jpg"));
            course.AddHole(0, 0, 0, 0, Path.Combine("images", "Final.jpg"));
            #endregion

            btnGetWeather_Click();
        }

        private void UpdateLabels()
        {
            #region Label Update
            HoleNumber.Text = $"Hole Number: {course.Holes[currentHole].Number}";
            Par.Text = $"Par: {course.Holes[currentHole].Par}";
            Yardage.Text = $"Yardage: {course.Holes[currentHole].Yardage}";
            HoleDifficulty.Text = $"Rating: {course.Holes[currentHole].Rating}";
            Image holeImage = Image.FromFile(course.Holes[currentHole].Image);
            HoleImage.SizeMode = PictureBoxSizeMode.Zoom;
            HoleImage.Image = holeImage;
            #endregion 
        }

        private async void btnGetWeather_Click()
        {
            #region Weather
            string city = Weather.Text;

            try
            {
                WeatherData weatherData = await weatherApi.GetWeatherAsync(city);

                Temp.Text = $"Temperature: {weatherData.current.temp_f} °F";
                Wind.Text = $"Wind: {weatherData.current.wind_mph} mph";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion 
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
