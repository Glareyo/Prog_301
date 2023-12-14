    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Credit:
//Derek Banas => https://www.youtube.com/watch?v=jbwjbbc5PjI&list=WL&index=61
// Demonstrated serialization and implementations
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Sprint5HW.Result_Classes
{
    public class ResultRepo
    {
        List<IResult> results;
        IResult SavedResult;

        public ResultRepo()
        {
            results = new List<IResult>();
            SavedResult = null;
        }




        //Credit:
        //Derek Banas => https://www.youtube.com/watch?v=jbwjbbc5PjI&list=WL&index=61
        // Demonstrated serialization and implementations
        public virtual void AddResult(Result result)
        {
            Stream stream = File.Open("ResultsData.dat", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf = new BinaryFormatter();
            bf.Serialize(stream, result);

            stream.Close();
        }

        //Credit:
        //Derek Banas => https://www.youtube.com/watch?v=jbwjbbc5PjI&list=WL&index=61
        // Demonstrated serialization and implementations
        public virtual Result PrintResult()
        {
            Stream stream = File.Open("ResultsData.dat", FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            bf = new BinaryFormatter();

            Result r = (Result)bf.Deserialize(stream);
            stream.Close();

            return r;
        }
    }
}
