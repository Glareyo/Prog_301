using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Currency
{
    public class Coin : ICoin
    {
        public Coin()
        {

        }

        public double MonetaryValue { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string About()
        {
            throw new NotImplementedException();
        }
    }
}
