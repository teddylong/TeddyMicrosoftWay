using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayPatterns.State
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
