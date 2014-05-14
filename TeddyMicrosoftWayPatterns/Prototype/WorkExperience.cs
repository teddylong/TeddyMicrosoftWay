using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayPatterns.Prototype
{
    public class WorkExperience: ICloneable
    {
        private string workDate;

        public string WorkDate
        {
            get { return workDate; }
            set { workDate = value; }
        }
        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
