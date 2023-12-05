using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Course
{
    public string Name { get; set; }
    public List<Hole> Holes { get; set; }

    public Course()
    {
        Holes = new List<Hole>();
    }

    public void AddHole(Hole hole)
    {
        Holes.Add(hole);
    }
}

public class Hole
{
    public int Number { get; set; }
    public int Par { get; set; }
    public int Yardage { get; set; }
    // Add more properties as needed
}
