using SportsLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Sports
{
    public class Baseball : Sport
    {
        public Baseball()
        {
            Name = "Baseball";
            Description = "A game where people hit balls with bats.";
            MaxTeams = 2;
        }
    }
}
