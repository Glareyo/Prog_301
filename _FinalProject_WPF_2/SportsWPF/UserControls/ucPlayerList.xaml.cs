using SportsWPF.Pages;
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
    /// Interaction logic for ucPlayerList.xaml
    /// </summary>
    public partial class ucPlayerList : UserControl
    {
        public vmPlayerRepo vmPlayerRepo;
        public vmPlayer vmPlayer;


        public ucPlayerList()
        {
            InitializeComponent();

            vmPlayer = new vmPlayer();
            DataContext = vmPlayer;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            int num = Convert.ToInt32(s.Content);

            vmPlayer p = new vmPlayer(vmPlayerRepo.PlayersList[num - 1]);
        }
    }
}
