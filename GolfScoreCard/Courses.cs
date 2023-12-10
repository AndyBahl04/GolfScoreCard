using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GolfScoreCard
{
    internal class Courses
    {
        public class Course
        {
            public string Name { get; set; }
            public List<Hole> Holes { get; set; }

            public Course()
            {
                Holes = new List<Hole>();
            }

            public void AddHole(int number, int par, int yardage, int rating, string image)
            {
                Holes.Add(new Hole { Number = number, Par = par, Yardage = yardage, Rating = rating, Image = image });

            }
        }
        public class Hole
        {
            public int Number { get; set; }
            public int Par { get; set; }
            public int Yardage { get; set; }
            public int Rating { get; set; }
            public string Image { get; set; }
        }
    }
}

