// Nehemiah Cedillo

//Credits:
// https://www.youtube.com/watch?v=18KrD8bpIXY => Learn With Umair
// Helped demonstrate how to implement user controls

// https://www.youtube.com/watch?v=udNudU3iaRQ =>  Aaric Aaiden
// Helped demonstrate how to access and insert user controls into the mainWindow.

// https://www.youtube.com/watch?v=fOookEq5od0 => Eduardo Rosas
// Helped demonstrate how to implement ICommands.


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

namespace Sprint5HW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = new CalculatorViewModel();
            CalculatorButtons.vm = this.vm;
            uc_Display.DataContext = vm;
        }
    }
}
