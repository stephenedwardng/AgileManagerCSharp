using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManager
{
    class Bug : Item
    {
        private Severity severity;

        public Bug(string title, string component, string description, int devEffort, int testEffort, Stakeholder requestor, Priority priority, Severity severity) : base( title,  component,  description,  devEffort,  testEffort,  requestor,  priority)
        {
            this.Severity = severity;
        }

        public Severity Severity { get => severity; set => severity = value; }
    }
}
