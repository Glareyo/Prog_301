using Sprint5HW.Result_Classes;
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
        //Credits:
        // https://www.youtube.com/watch?v=18KrD8bpIXY => Learn With Umair
        // Helped demonstrate how to implement user controls

        // https://www.youtube.com/watch?v=udNudU3iaRQ =>  Aaric Aaiden
        // Helped demonstrate how to access and insert user controls into the mainWindow.

        public CalculatorViewModel vm { get; set; }
        public ResultViewModel resultVM { get; set; }

        bool mathCharInputted;
        bool intInputted;

        public ucCalculatorButtons()
        {
            InitializeComponent();
            mathCharInputted = false;
            intInputted = false;

            CheckInputs();
        }

        private void b_numberClicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            vm.CurrentNumber = b.Content.ToString();
            resultVM.CurrentInputtedInt = Convert.ToInt32(b.Content);

            intInputted = true;
            CheckInputs();
        }

        private void b_mathCharClicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            vm.MathChar = (Convert.ToChar(b.Content.ToString()));
            resultVM.CurrentMathChar = Convert.ToChar(b.Content.ToString());

            mathCharInputted = true;
            CheckInputs();
        }

        private void b_calculateClicked(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            vm.Result = vm.CalculateResult();
            vm.CurrentNumber = "";
            vm.MathChar = ' ';

            resultVM.FullResultOutput = vm.Result.ToString();
            resultVM.ResultOutput = vm.Result;

            mathCharInputted = false;
            intInputted=false;
            CheckInputs();
        }

        private void CheckInputs()
        {
            if (mathCharInputted && intInputted)
            {
                b_equal.IsEnabled = true;
            }
            else
            {
                b_equal.IsEnabled = false;
            }
        }
    }
}
