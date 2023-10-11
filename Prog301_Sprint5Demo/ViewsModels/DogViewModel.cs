using Prog301_Sprint5Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_Sprint5Demo.ViewsModels
{
    /// <summary>
    /// A specific class that directly interacts with the WPF
    /// THe dog class itself DOES NOT Interact with the WPF.
    /// </summary>
    public class DogViewModel : INotifyPropertyChanged
    {
        public Dog dog;

        public string Name
        {
            get { return dog.Name; }
            set
            {
                dog.Name = value;
                OnPropertyChanged();
            }
        }
        public int Age
        {
            get { return dog.Age; }
            set
            {
                dog.Age = value;
                OnPropertyChanged();
            }
        }
        public int Weight
        {
            get { return dog.Weight; }
            set
            {
                dog.Weight = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public DogViewModel(Dog _dog) 
        {
            this.dog = _dog;
        }
    }
}
