using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Sports
{
    public class Sport : ISport
    {
        public Sport()
        {

        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
