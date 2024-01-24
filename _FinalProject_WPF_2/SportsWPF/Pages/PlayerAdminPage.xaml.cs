using SportsWPF.UserControls;
using SportsWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for PlayerAdminPage.xaml
    /// </summary>
    public partial class PlayerAdminPage : Page
    {
        static public vmPlayer targetPlayerVM;
        public vmPlayerRepo playerRepoVM;

        static public TextBox TTest;


        public PlayerAdminPage()
        {
            InitializeComponent();

            TTest = test;

            playerRepoVM = MainWindow.vmPlayerRepo;

            DataContext = playerRepoVM;

            uc_List.vmPlayerRepo = playerRepoVM;
            uc_List.DataContext = playerRepoVM;

            foreach(var player in uc_List.vmPlayerRepo.PlayersList)
            {
                TTest.Text += " "+ player.Name;
            }
        }

        private void bBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BackToMenu();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int num = Convert.ToInt32(b.Content);

            targetPlayerVM = new vmPlayer(playerRepoVM.PlayersList[num-1]);
            playerDisplay.DataContext = targetPlayerVM;
            PlayerEditor.DataContext = targetPlayerVM;
            PlayerEditor.playerVM = targetPlayerVM;
        }
    }
}
