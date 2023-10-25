using DogLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sprint6.ViewModels
{
    internal class MammalViewModel : BaseViewModel
    {
        IMammal mammal;

        public string Name { 
            get { return mammal.Name; }
            set {
                RaisePropertyChangedEvent();
                this.mammal.Name = value; }
        }

        public int Age
        {
            get { return mammal.Age; }
            set
            {
                RaisePropertyChangedEvent();
                
            }
        }

        public int Weight
        {
            get { return mammal.Weight; }
            set
            {
                
                RaisePropertyChangedEvent();

            }
        }

        public MammalViewModel(IMammal mam)
        {
            this.mammal = mam;
        }
        
    }
}
