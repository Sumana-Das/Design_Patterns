using System;

namespace AdaptorDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            string xmlData = "<XML>data</XML>";
            Adapter tool = new Adapter();
            tool.AnalyseDataWithConversion(xmlData);
        }
    }
}
