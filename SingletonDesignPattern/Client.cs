using System;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Client
    {
        static void User1(string message)
        {
            LazyLoadingLogger lazyUser1 = LazyLoadingLogger.getLogger();
            lazyUser1.Log(message);

            EagerLoadingLogger eagerUser1 = EagerLoadingLogger.getLogger();
            eagerUser1.Log(message);
        }
        static void User2(string message)
        {
            LazyLoadingLogger lazyUser2 = LazyLoadingLogger.getLogger();
            lazyUser2.Log(message);

            EagerLoadingLogger eagerUser2 = EagerLoadingLogger.getLogger();
            eagerUser2.Log(message);
        }

        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => User1("Calling from User 1"),
                () => User2("Calling from User 2")
                );
            Console.ReadLine();
        }
    }
}
