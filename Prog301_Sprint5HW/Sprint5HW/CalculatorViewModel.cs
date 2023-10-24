using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sprint5HW
{
    public class CalculatorViewModel : BaseViewModel
    {
        public Calculator calc;

        public CalculatorViewModel()
        {
            calc = new Calculator();
        }

        public int Result
        {
            get { return calc.Result; }
            set 
            {
                calc.Result = value;
                OnPropertyChanged();
            }   
        }
        public int CalculateResult()
        {
            return calc.calculate();
        }

        public char MathChar
        {
            get { return calc.MathChar; } 
            set
            {
                calc.changeMathChar(Convert.ToChar(value));
                OnPropertyChanged();
            }
        }
        public string CurrentNumber
        {
            get { return calc.currentNumber; }
            set
            {
                calc.inputNumber(value);
                OnPropertyChanged();
            }
        }

        

    }
}
