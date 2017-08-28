using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AgileManager
{
    [TestFixture]
    public class TestRoadmap
    {
        Item item1;
        Feature feature1;
        Version version;
        Roadmap roadmap;
        DateTime date1;
        List<Item> items;

        [SetUp]
        public void Init()
        {
            date1 = new DateTime(2018, 3, 1, 7, 0, 0);
            item1 = new Item("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium);
            feature1 = new Feature("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium, Reason.Regulatory);
            version = new Version(1.1, Significance.Minor, date1, "Accommodates next phase of regulatory requirements re data storage and minor client requests.", items, 9, 3);
            roadmap = new Roadmap("Agile Manager","Consolidates Product Owners managerial responsibilities for the future direction of the product", 21);
        }

        [Test]
        public void TestHasProduct()
        {
            Assert.AreEqual("Agile Manager", roadmap.Product);
        }

        [Test]
        public void TestHasOverview()
        {
            Assert.AreEqual("Consolidates Product Owners managerial responsibilities for the future direction of the product", roadmap.Overview);
        }

        [Test]
        public void TestHasReleaseCycle()
        {
            Assert.AreEqual(21, roadmap.ReleaseCycle);
        }


    }
}
