using DogLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDog.Models;

namespace WpfAppDog.ViewModels
{
    public class ViewModelMammals
    {

        private static ObservableCollection<ViewModelMammal> mammals;

        public ObservableCollection<ViewModelMammal> Mammals
        {
            get { return mammals; }
            set { mammals = value; }
        }

        public void LoadMammals()
        {
            if (mammals == null)
            {
                mammals = new ObservableCollection<ViewModelMammal>()
                {
                    new ViewModelMammal ( new Dog{ BarkSound="woof!", Name="fido"}),
                    new ViewModelMammal ( new Dog{ BarkSound="arf!", Name="rover"}),
                    new ViewModelMammal ( new Dog{ BarkSound="arf!", Name="milo"}),
                    new ViewModelMammal ( new Dog{ BarkSound="arf!", Name="spot"})
                };
            }

            Mammals = mammals;
        }
    }
}
