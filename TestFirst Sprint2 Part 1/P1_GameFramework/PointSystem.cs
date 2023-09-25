using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_GameFramework
{
    public class PointSystem
    {
        // Number of points this system has.
        public int points;
        
        // The particular name of the system.
        private string name;

        public PointSystem(string _name, int _points)
        {
            name = _name;
            points = _points;
        }

        public void AddPoints(int numOfPoints)
        {
            points += numOfPoints;
        }
    }
}