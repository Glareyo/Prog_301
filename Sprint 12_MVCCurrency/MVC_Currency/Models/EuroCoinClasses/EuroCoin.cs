using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Currency
{
    public class EuroCoin : Coin
    {
        public virtual string About()
        {
            string about = $"The {Name} is from {Year}. It is worth €{MonetaryValue}.";
            return about;
        }

        public EuroCoin()
        {
            Year = System.DateTime.Now.Year;
            
        }
    }
}
