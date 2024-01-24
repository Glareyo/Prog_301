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
    /// Interaction logic for ucAdminPlayer.xaml
    /// </summary>
    public partial class ucAdminPlayer : UserControl
    {
        public vmPlayer playerVM { get; set; }
        public ucAdminPlayer()
        {
            InitializeComponent();
        }

        private void b_ChangeName_Click(object sender, RoutedEventArgs e)
        {
            playerVM.UpdateName(tBox_input.Text);
        }

        private void b_ChangeNumber_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(tBox_input.Text);
            }
            catch
            {
                num = 0;
            }
            playerVM.UpdateNumber(num);
        }
    }
}
