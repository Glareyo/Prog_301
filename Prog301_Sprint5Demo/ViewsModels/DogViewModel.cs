using Prog301_Sprint5Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prog301_Sprint5Demo.ViewsModels
{
    /// <summary>
    /// A specific class that directly interacts with the WPF
    /// THe dog class itself DOES NOT Interact with the WPF.
    /// </summary>
    public class DogViewModel : BaseViewModel
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

        public void Eat()
        {
            this.dog.Eat();
            OnPropertyChanged("Weight");     
        }

        public void Poop()
        {
            this.dog.Poop();
            OnPropertyChanged("Weight");
        }

        

        public DogViewModel(Dog _dog) 
        {
            this.dog = _dog;
        }
    }
}
