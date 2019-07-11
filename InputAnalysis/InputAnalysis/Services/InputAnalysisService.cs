using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputAnalysis.Services
{
    public class InputAnalysisService
    {
        public InputAnalysisService()
        {
            //empty constructor
        }



        public (List<double> intList, List<string> stringList) ProcessInput(string input)
        {
            var retIntList = new List<double>();
            var retStringList = new List<string>();

            var splitInput = input.Split(Environment.NewLine);   
            foreach(var s in splitInput)
            {
                if(double.TryParse(s, out var parsedAsDouble))
                {
                    retIntList.Add(parsedAsDouble);
                }
                else
                {
                    retStringList.Add(s);
                }
            }

            return (retIntList, retStringList);
        }
    }
}
