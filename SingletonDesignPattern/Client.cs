using System;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Client
    {
        static void User1(string message, string loggerType)
        {
            ISingleton lazyUser1 = LoggerFactory.GetLoggerType(loggerType);
            lazyUser1.Log(message);

            ISingleton eagerUser1 = LoggerFactory.GetLoggerType(loggerType);
            eagerUser1.Log(message);
        }
        static void User2(string message, string loggerType)
        {
            ISingleton lazyUser2 = LoggerFactory.GetLoggerType(loggerType);
            lazyUser2.Log(message);

            ISingleton eagerUser2 = LoggerFactory.GetLoggerType(loggerType);
            eagerUser2.Log(message);
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => User1("Calling from User 1", "Lazy"),
                () => User2("Calling from User 2", "Eager")
                );
            Console.ReadLine();
        }
    }
}
