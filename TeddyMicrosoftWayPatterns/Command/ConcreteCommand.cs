using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayPatterns.Command
{
    class ConcreteCommand: Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        { }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
