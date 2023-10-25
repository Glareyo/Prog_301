using DogLibrary;
using Sprint6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sprint6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        IMammal mammal, mammal2;
        
        public MainWindow()
        {
            InitializeComponent();
            mammal = new Dog();
            mammal2 = new Dog() { Name="milo", Weight=3};
            //this.DataContext = new MammalViewModel(mammal);
            this.Mammal1.DataContext = new MammalViewModel(mammal);
            this.Mammal2.DataContext = new MammalViewModel(mammal2);
        }

       
    }
}
