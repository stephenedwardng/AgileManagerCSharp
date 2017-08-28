using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManager
{
    class Feature : Item
    {
        private Reason reason;

        public Feature(string title, string component, string description, int devEffort, int testEffort, Stakeholder requestor, Priority priority, Reason reason) : base( title,  component,  description,  devEffort,  testEffort,  requestor,  priority)
        {
            this.Reason = reason;
        }

        public Reason Reason { get => reason; set => reason = value; }
    }
}
