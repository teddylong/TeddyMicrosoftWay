﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayPatterns.Singleton
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
