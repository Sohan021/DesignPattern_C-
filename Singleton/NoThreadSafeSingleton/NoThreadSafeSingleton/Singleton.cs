using System;

namespace NoThreadSafeSingleton
{
    public sealed class Singleton
    {
        private static int c = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
            c++;
            Console.WriteLine("Counter Value " + c.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
