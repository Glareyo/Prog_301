using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sprint5HW.Result_Classes
{
    [Serializable()]
    public class Result : IResult, ISerializable
    {
        public int resultOutput { get; set; }

        public string fullResultOutput { get; set; }


        public char currentMathChar;
        public int currentInputtedInt;

        public Result()
        {
            fullResultOutput = "0";
        }

        public string UpdateFullResult(string _result)
        {
            int result = Convert.ToInt32(_result);

            fullResultOutput += $" {currentMathChar} {currentInputtedInt}";

            resultOutput = result;

            return fullResultOutput;
        }


        //Credit:
        //Derek Banas => https://www.youtube.com/watch?v=jbwjbbc5PjI&list=WL&index=61
        // Demonstrated serialization and implementations
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Result", resultOutput);
            info.AddValue("FullResultOutput", fullResultOutput);
        }
        public Result(SerializationInfo info, StreamingContext context)
        {
            resultOutput = (int)info.GetValue("Result", typeof(int));
            fullResultOutput = (string)info.GetValue("FullResultOutput", typeof(string));
        }
    }
}