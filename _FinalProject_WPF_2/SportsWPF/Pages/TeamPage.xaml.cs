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

namespace SportsWPF.Pages
{
    /// <summary>
    /// Interaction logic for TeamPage.xaml
    /// </summary>
    public partial class TeamPage : Page
    {
        public vmTeamRepo teamRepo { get; set; }

        public TeamPage()
        {
            InitializeComponent();

            DataContext = MainWindow.vmTeamRepo;
            teamRepo = MainWindow.vmTeamRepo;

            stack_teamList.DataContext = MainWindow.vmTeamRepo;
        }

        private void bBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BackToMenu();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int num = Convert.ToInt32(b.Content);

            vmTeam t = new vmTeam(teamRepo.TeamsList[num]);

            TeamEditor.vmTeam = t;
            TeamEditor.DataContext = t;
        }
    }
}
