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
    /// Interaction logic for PlayerAdminPage.xaml
    /// </summary>
    public partial class PlayerAdminPage : Page
    {
        static public vmPlayer playerVM;
        public vmPlayerRepo playerRepoVM;


        public PlayerAdminPage()
        {
            InitializeComponent();

            playerVM = new vmPlayer();

            playerRepoVM = MainWindow.vmPlayerRepo;

            /*uc_PlayerList.DataContext = playerRepoVM;
            uc_PlayerList.vmPlayer = playerVM;
            uc_PlayerList.vmPlayerRepo = playerRepoVM;

            uc_PlayerEditor.DataContext = playerVM;
*/
            playerVM.Player = playerRepoVM.PlayersList[0];
        }

        private void bBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.BackToMenu();
        }
    }
}
