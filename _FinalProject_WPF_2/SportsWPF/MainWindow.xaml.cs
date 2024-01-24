using SportsLibrary.Repos;
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

namespace SportsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public vmPlayer vmPlayer;
        static public vmPlayerRepo vmPlayerRepo;
        static public vmTeamRepo vmTeamRepo;


        static Frame MainFrame;

        public MainWindow()
        {
            InitializeComponent();

            MainFrame = F_Main;
            F_Main.Visibility = Visibility.Hidden;

            vmPlayer = new vmPlayer();
            vmPlayerRepo = new vmPlayerRepo();

            vmTeamRepo = new vmTeamRepo(new TeamsRepo());
        }

        private void bPlayers_MouseEnter(object sender, MouseEventArgs e)
        {
            MainFrame.Source = new Uri("../../Pages/PlayerAdminPage.xaml", UriKind.Relative);
        }
        private void bTeams_MouseEnter(object sender, MouseEventArgs e)
        {
            MainFrame.Source = new Uri("../../Pages/TeamPage.xaml", UriKind.Relative);
        }

        private void bPlayers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Visible;
        }



        public static void BackToMenu()
        {
            MainFrame.Visibility = Visibility.Hidden;
        }

        private void F_Main_Navigated(object sender, NavigationEventArgs e)
        {

        }

       
    }
}
