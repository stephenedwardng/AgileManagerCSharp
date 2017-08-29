using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManager
{
    class Version : Versionable, Feasible
    {
        private double semanticVersionNo;
        private Significance significance;
        private DateTime releaseDate;
        private string topLevelScope;
        private List<Item> items;
        private int daysAllocated;
        private int developerResource;

        public Version(double semanticVersionNo, Significance significance, DateTime releaseDate, string topLevelScope, List<Item> items, int daysAllocated, int developerResource)
        {
            this.semanticVersionNo = semanticVersionNo;
            this.significance = significance;
            this.releaseDate = releaseDate;
            this.topLevelScope = topLevelScope;
            this.items = items;
            this.daysAllocated = daysAllocated;
            this.developerResource = developerResource;
        }

        public double SemanticVersionNo { get => semanticVersionNo; set => semanticVersionNo = value; }
        public Significance Significance { get => significance; set => significance = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string TopLevelScope { get => topLevelScope; set => topLevelScope = value; }
        public List<Item> Items { get => items; set => items = value; }
        public int DaysAllocated { get => daysAllocated; set => daysAllocated = value; }
        public int DeveloperResource { get => developerResource; set => developerResource = value; }

        public int CalcManDays()
        {
            return this.daysAllocated * this.developerResource;
        }

        public int DaysUsed()
        {
            int daysUsed = 0;

            foreach(Item i in items)
            {
                daysUsed += i.CalcTotalEffort();
            }
                
            return daysUsed;
        }

        public bool IsFeasible()
        {
            return DaysUsed() <= CalcManDays(); 
        }

        public int PriorityCount(Priority priority)
        {
            int count = 0;

//            foreach (Item item in items)
//            {
//                if (item.getPriority == priority)
//                {
//                    count++;
//                }
//            }
            return count;
        }

        public Significance CalcSignificance()
        {
            Significance significance;

            if (PriorityCount(Priority.High) == 0 && PriorityCount(Priority.Medium) == 0)
            {
                significance = Significance.Maintenance;
            } else if (PriorityCount(Priority.High) > (PriorityCount(Priority.Medium) + PriorityCount(Priority.Low)))
            {
                significance = Significance.Major;
            } else 
            {
                significance = Significance.Minor;
            }

            return significance;
        }

        public int ItemCount()
        {
            return this.items.Count;
        }

        public void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public void ClearItems()
        {
            this.items.Clear();
        }

    }

}

