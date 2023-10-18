using Prog301_Sprint5Demo.Models;
using Prog301_Sprint5Demo.ViewsModels;
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

namespace Prog301_Sprint5Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DogViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new DogViewModel(new Dog() { Name = "Jericho" });

            this.DataContext = vm;
        }

        private void btnHappyBirthday_Click(object sender, RoutedEventArgs e)
        {
            vm.Age += 1;
        }

        private void btnEat_Click(object sender, RoutedEventArgs e)
        {
            vm.Eat();
        }

        private void btnPoop_Click(object sender, RoutedEventArgs e)
        {
            vm.Poop();
        }
    }
}
