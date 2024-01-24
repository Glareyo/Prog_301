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
using SportsLibrary;
using SportsWPF.Pages;
using SportsWPF.ViewModels;

namespace SportsWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public vmPlayer vmPlayer;
        static public vmPlayerRepo vmPlayerRepo;


        static Frame MainFrame;

        public MainWindow()
        {
            InitializeComponent();

            MainFrame = F_Main;
            F_Main.Visibility = Visibility.Hidden;

            vmPlayer = new vmPlayer();
            vmPlayerRepo = new vmPlayerRepo();

        }

        private void bPlayers_MouseEnter(object sender, MouseEventArgs e)
        {
            MainFrame.Source = new Uri("../../Pages/PlayerAdminPage.xaml", UriKind.Relative);
        }
        private void bPlayers_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Visible;
        }



        public static void BackToMenu()
        {
            MainFrame.Visibility = Visibility.Hidden;
        }

        
    }
}
