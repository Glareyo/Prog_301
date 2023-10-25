using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sprint6.ViewModels
{
    public abstract class BaseViewModel : DependencyObject, INotifyPropertyChanged
    {
        //Implement INothify property changes c# 6 way
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected void RaisePropertyChangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
