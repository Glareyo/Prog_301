using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint5HW.Result_Classes
{
    public class ResultViewModel : BaseViewModel
    {
        public Result result { get; set; }

        public ResultViewModel()
        {
            result = new Result();
        }

        public void DiscardResult()
        {
            result = new Result();
        }

        public char CurrentMathChar
        {
            set { result.currentMathChar = value; }
        }
        public int CurrentInputtedInt
        {
            set { result.currentInputtedInt = value; }
        }

        public string FullResultOutput
        {
            get { return result.fullResultOutput; }
            set
            {
                result.UpdateFullResult(value.ToString());
                OnPropertyChanged();
            }
        }

        public string SeralizedFullResultOutput
        {
            set
            {
                result.fullResultOutput = value;
                OnPropertyChanged();
            }
        }

        public int ResultOutput
        {
            get { return result.resultOutput; }
            set
            {
                result.resultOutput = value;
                OnPropertyChanged();
            }
        }
    }
}
