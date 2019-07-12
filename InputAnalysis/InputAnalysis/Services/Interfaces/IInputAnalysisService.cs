using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputAnalysis.Services.Interfaces
{
    public interface IInputAnalysisService
    {
        (List<double> intList, List<string> stringList) ProcessInput(string input);

        double GetSumOfAllNumbers();

        int GetCountOfAllNumbers();

        bool ContainsString(string str);

        bool ContainsSubString(string str);

        (List<double> intList, List<string> stringList) GetFullProcessedData();
    }
}
