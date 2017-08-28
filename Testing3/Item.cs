using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManager
{
    class Item
    {
        protected string title;
        protected string component;
        protected string description;
        protected int devEffort;
        protected int testEffort;
        protected Stakeholder requestor;
        protected Priority priority;

        public Item(string title, string component, string description, int devEffort, int testEffort, Stakeholder requestor, Priority priority)
        {
            this.Title = title;
            this.Component = component;
            this.Description = description;
            this.DevEffort = devEffort;
            this.TestEffort = testEffort;
            this.Requestor = requestor;
            this.Priority = priority;
        }

        public string Title { get => title; set => title = value; }
        public string Component { get => component; set => component = value; }
        public string Description { get => description; set => description = value; }
        public int DevEffort { get => devEffort; set => devEffort = value; }
        public int TestEffort { get => testEffort; set => testEffort = value; }
        public Stakeholder Requestor { get => requestor; set => requestor = value; }
        public Priority Priority { get => priority; set => priority = value; }

        public int CalcTotalEffort()
        {
            return devEffort + testEffort;
        }
    }
}

