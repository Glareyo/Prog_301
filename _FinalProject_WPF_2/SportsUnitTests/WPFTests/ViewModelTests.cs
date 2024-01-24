using SportsWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsUnitTests.WPFTests
{
    [TestClass]
    public class ViewModelTests
    {
        vmPlayer playerViewModel;
        vmPlayerRepo playerViewModelRepo;

        public ViewModelTests()
        {
            playerViewModel = new vmPlayer();
            playerViewModelRepo = new vmPlayerRepo();
        }

        [TestMethod]
        public void IsABaseVM()
        {
            Assert.IsInstanceOfType(playerViewModel, typeof(vmBase));
            Assert.IsInstanceOfType(playerViewModelRepo, typeof(vmBase));
        }
    }
}
