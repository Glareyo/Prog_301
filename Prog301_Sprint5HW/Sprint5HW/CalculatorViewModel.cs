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
    public class CalculatorViewModel : INotifyPropertyChanged
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

        //Credit ==> Programming 301 Lecture from Jeff Meyers, FA23-PROG 301-01

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
