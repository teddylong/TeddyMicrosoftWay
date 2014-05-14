using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayPatterns.Singleton
{
    class SingletonV2
    {
        private static SingletonV2 instance;
        private static readonly object syncRoot = new object();

        private SingletonV2() { }

        public static SingletonV2 GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new SingletonV2();
                    }
                }
            }
            return instance;
        }
    }
}
