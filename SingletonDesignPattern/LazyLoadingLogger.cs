using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class LazyLoadingLogger : ISingleton
    {
        static LazyLoadingLogger logger;
        static int countInstance = 0;
        static readonly object instanceLock = new object();

        LazyLoadingLogger()
        {
            countInstance++;
            Console.WriteLine("Lazy Logger Instance created: " + countInstance);
        }
        public static LazyLoadingLogger getLogger()
        {
            if(logger == null)
            {
                lock(instanceLock)
                {
                    if (logger == null)
                    {
                        logger = new LazyLoadingLogger();
                    }
                }
            }
            return logger;
        }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
