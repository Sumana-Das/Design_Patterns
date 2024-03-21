using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class LoggerFactory
    {
        public static ISingleton GetLoggerType(string loggerType)
        {
            ISingleton logger = null;
            if (loggerType == "Lazy")
            {
                logger = LazyLoadingLogger.getLogger();
            }
            else if (loggerType == "Eager")
            {
                logger = EagerLoadingLogger.getLogger();
            }
            return logger;
        }
    }
}
