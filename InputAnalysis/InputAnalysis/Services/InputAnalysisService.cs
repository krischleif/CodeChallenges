using InputAnalysis.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputAnalysis.Services
{
    public class InputAnalysisService : IInputAnalysisService
    {
        public InputAnalysisService()
        {
            //empty constructor
        }

        public double GetSumOfAllNumbers()
        {
            (var doubleRes, var stringRes) = this.ProcessInput(System.IO.File.ReadAllText("InputFile/Input.txt"));

            return Math.Round(doubleRes.Sum(), 2);
        }

        public int GetCountOfAllNumbers()
        {
            (var doubleRes, var stringRes) = this.ProcessInput(System.IO.File.ReadAllText(@"InputFile/Input.txt"));

            return doubleRes.Count;
        }

        public bool ContainsString(string str)
        {
            (var doubleRes, var stringRes) = this.ProcessInput(System.IO.File.ReadAllText("InputFile/Input.txt"));

            return stringRes.Contains(str);
        }

        public bool ContainsSubString(string str)
        {
            (var doubleRes, var stringRes) = this.ProcessInput(System.IO.File.ReadAllText("InputFile/Input.txt"));

            return stringRes.Any(x => x.Contains(str));
        }

        public (List<double> intList, List<string> stringList) GetFullProcessedData()
        {
            return this.ProcessInput(System.IO.File.ReadAllText("InputFile/Input.txt"));
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
