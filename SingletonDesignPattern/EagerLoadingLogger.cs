using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    class EagerLoadingLogger : ISingleton
    {
        static int countInstance = 0;
        static readonly EagerLoadingLogger logger = new EagerLoadingLogger();

        EagerLoadingLogger()
        {
            countInstance++;
            Console.WriteLine("Eager Logger Instance created: "+ countInstance);
        }
        public static EagerLoadingLogger getLogger()
        {
            return logger;
        }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
