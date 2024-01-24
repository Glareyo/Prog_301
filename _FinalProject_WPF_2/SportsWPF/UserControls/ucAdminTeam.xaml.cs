using SportsWPF.ViewModels;
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

namespace SportsWPF.UserControls
{
    /// <summary>
    /// Interaction logic for ucAdminTeam.xaml
    /// </summary>
    public partial class ucAdminTeam : UserControl
    {
        public vmTeam vmTeam; 

        public ucAdminTeam()
        {
            InitializeComponent();
        }

        private void b_ChangeName_Click(object sender, RoutedEventArgs e)
        {

            Button b = sender as Button;

            vmTeam.TeamName = tBox_Name.Text;
        }

        private void b_ChangeDescription_Click(object sender, RoutedEventArgs e)
        {
            vmTeam.TeamDescription = tBox_Description.Text;
        }
    }
}
