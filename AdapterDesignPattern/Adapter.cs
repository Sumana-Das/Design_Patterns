using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern
{
    class Adapter : DataAnalyticsTool
    {
        public void AnalyseDataWithConversion(string xml)
        {
            XMLData xmlData = new XMLData(xml);

            Console.WriteLine("Converting xml data: " + xml + " to json");
            string json = xmlData.xmlData.Replace("XML","JSON");
            Console.WriteLine("Conversion done.");

            AnalyseData(json);
        }
    }
}
