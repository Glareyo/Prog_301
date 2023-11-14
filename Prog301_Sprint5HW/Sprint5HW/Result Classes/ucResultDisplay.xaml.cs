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

namespace Sprint5HW.Result_Classes
{
    /// <summary>
    /// Interaction logic for ucResultDisplay.xaml
    /// </summary>
    public partial class ucResultDisplay : UserControl
    {
        public ResultViewModel resultViewModel { get; set; }
        public ResultRepoViewModel resultRepo { get; set; }

        public ucResultDisplay()
        {
            InitializeComponent();
        }

        private void b_Save_Click(object sender, RoutedEventArgs e)
        {
            resultRepo.SaveResult(resultViewModel.result);
        }

        private void b_Discard_Click(object sender, RoutedEventArgs e)
        {
            resultViewModel.DiscardResult();
            tb_fullOutput.Text = "0";
            tb_result.Text = "0";
        }

        private void b_Print_Click(object sender, RoutedEventArgs e)
        {
            Result r = resultRepo.PrintResult();

            tb_fullOutput.Text = r.fullResultOutput;
            tb_result.Text = r.resultOutput.ToString();
        }
    }
}
