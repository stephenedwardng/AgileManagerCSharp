using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileManager
{
    class Roadmap : Rangeable
    {
        private string product;
        private string overview;
        private int releaseCycle;
        private List<Version> versions;

        public string Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

        public string Overview
        {
            get { return this.overview; }
            set { this.overview = value; }
        }

        public int ReleaseCycle
        {
            get { return this.releaseCycle; }
            set { this.releaseCycle = value; }
        }

        public Roadmap(string product, string overview, int releaseCycle)
        {
            this.product = product;
            this.overview = overview;
            this.releaseCycle = releaseCycle;
            this.versions = new List<Version>();
        }

        public int VersionCount()
        {
            return this.versions.Count;
        }

        public void AddVersion(Version version)
        {
            this.versions.Add(version);
        }

        public void ClearVersions()
        {
            this.versions.Clear();
        }

        public int CalcRange()
        {
            return VersionCount() * releaseCycle;
        }
    }

}

