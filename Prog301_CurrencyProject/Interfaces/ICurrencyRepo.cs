using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject
{
    public interface ICurrencyRepo
    {
        
        List<ICoin> Coins { get; set; }
        string About();
        void AddCoin(ICoin c);
        int GetCoinCount();
        ICurrencyRepo MakeChange(double amount);
        ICurrencyRepo MakeChange(double amountTendered,double totalCost);
        ICoin RemoveCoin(ICoin c);
        double TotalValue();
    }
}
