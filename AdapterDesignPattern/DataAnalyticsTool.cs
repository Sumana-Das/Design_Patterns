using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    class DataAnalyticsTool
    {
        public virtual void AnalyseData(string jsonData)
        {
            Console.WriteLine("Analysing json data: " + jsonData);
        }
    }
}
