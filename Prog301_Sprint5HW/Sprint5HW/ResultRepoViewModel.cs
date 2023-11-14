using Sprint5HW.Result_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint5HW
{
    public class ResultRepoViewModel
    {
        ResultRepo resultRepo;

        public ResultRepoViewModel()
        {
            resultRepo = new ResultRepo();
        }

        public void SaveResult(Result result)
        {
            resultRepo.AddResult(result);
        }
        public Result PrintResult()
        {
            return resultRepo.PrintResult();
        }
    }
}
