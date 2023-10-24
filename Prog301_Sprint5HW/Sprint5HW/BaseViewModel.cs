using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sprint5HW
{
    abstract public class BaseViewModel : INotifyPropertyChanged, ICommand
    {
        //Credit ==> Programming 301 Lecture from Jeff Meyers, FA23-PROG 301-01

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        // ICommand Interfaces
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new Exception();
        }
        public void Execute(object parameter)
        {
            throw new Exception();
        }

    }
}
