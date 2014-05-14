using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayPatterns.SimpleFactory
{
    public class OperationDiv: Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
            {
                throw new Exception("The NumberB can't be zero!");
            }
            else
            {
                result = NumberA / NumberB;
            }
            return result;
        }
    }
}
