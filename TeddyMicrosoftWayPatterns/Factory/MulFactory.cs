using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeddyMicrosoftWayPatterns.SimpleFactory;

namespace TeddyMicrosoftWayPatterns.Factory
{
    class MulFactory: IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
