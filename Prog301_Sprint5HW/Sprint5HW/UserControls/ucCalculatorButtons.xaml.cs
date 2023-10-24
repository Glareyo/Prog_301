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

namespace Sprint5HW.UserControls
{
    /// <summary>
    /// Interaction logic for ucCalculatorButtons.xaml
    /// </summary>
    public partial class ucCalculatorButtons : UserControl
    {
        public CalculatorViewModel vm { get; set; }


        public ucCalculatorButtons()
        {
            InitializeComponent();
        }

        private void b_numberClicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            vm.CurrentNumber = b.Content.ToString();
        }

        private void b_mathCharClicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            vm.MathChar = (Convert.ToChar(b.Content.ToString()));
        }

        private void b_calculateClicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            vm.Result = vm.CalculateResult();
            vm.CurrentNumber = "";
            vm.MathChar = ' ';
        }
    }
}
