using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AgileManager
{
    [TestFixture]
    public class TestVersion
    {
        Item item1;
        Feature feature1;
        Bug bug1;
        Version version;
        DateTime date1;
        List<Item> items;

        [SetUp]
        public void Init()
        {
            date1 = new DateTime(2018, 3, 1, 7, 0, 0);
            item1 = new Item("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium);
            feature1 = new Feature("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium, Reason.Regulatory);
            bug1 = new Bug("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.High, Severity.Critical);
            items = new List<Item>();
            version = new Version(1.1, Significance.Minor, date1, "Accommodates next phase of regulatory requirements re data storage and minor client requests.", items, 9, 3);
        }

        [Test]
        public void TestHasSemanticVersionNo()
        {
            Assert.AreEqual(1.1, version.SemanticVersionNo);
        }

        [Test]
        public void TestHasSignificance()
        {
            Assert.AreEqual(Significance.Minor, version.Significance);
        }

        [Test]
        public void TestHasReleaseDate()
        {
            Assert.AreEqual(date1, version.ReleaseDate);
        }

        [Test]
        public void TestHasTopLevelScope()
        {
            Assert.AreEqual("Accommodates next phase of regulatory requirements re data storage and minor client requests.", version.TopLevelScope);
        }

        [Test]
        public void TestHasItems()
        {
            Assert.AreEqual(items, version.Items);
        }

        [Test]
        public void TestHasDaysAllocated()
        {
            Assert.AreEqual(9, version.DaysAllocated);
        }

        [Test]
        public void TestHasDeveloperResource()
        {
            Assert.AreEqual(3, version.DeveloperResource);
        }

        [Test]
        public void TestCanCalcManDays()
        {
            Assert.AreEqual(27, version.CalcManDays());
        }

        [Test]
        public void TestCanCountEmptyList()
        {
            Assert.AreEqual(0, version.ItemCount());
        }

        [Test]
        public void TestCanAddItem()
        {
            version.AddItem(item1);
            Assert.AreEqual(1, version.ItemCount());
        }

        [Test]
        public void TestCanAddFeature()
        {
            version.AddItem(feature1);
            Assert.AreEqual(1, version.ItemCount());
        }

        [Test]
        public void TestCanAddBug()
        {
            version.AddItem(bug1);
            Assert.AreEqual(1, version.ItemCount());
        }

        [Test]
        public void TestCanClearItems()
        {
            version.AddItem(item1);
            version.AddItem(feature1);
            version.AddItem(bug1);
            version.ClearItems();
            Assert.AreEqual(0, version.ItemCount());
        }

        [Test]
        public void TestDaysUsed()
        {
            version.AddItem(item1);
            version.AddItem(feature1);
            version.AddItem(bug1);
            Assert.AreEqual(24, version.DaysUsed());
        }

        [Test]
        public void TestIsFeasible()
        {
            version.AddItem(item1);
            version.AddItem(feature1);
            version.AddItem(bug1);
            Assert.AreEqual(true, version.IsFeasible());
        }

        [Test]
        public void TestCanCountPriority_Low()
        {
            version.AddItem(item1);
            version.AddItem(feature1);
            version.AddItem(bug1);
            Assert.AreEqual(0, version.PriorityCount(Priority.Low));
        }

        [Test]
        public void TestCanCountPriority_Medium()
        {
            version.AddItem(item1);
            version.AddItem(feature1);
            version.AddItem(bug1);
            Assert.AreEqual(2, version.PriorityCount(Priority.Medium));
        }

        [Test]
        public void TestCanCountPriority_High()
        {
            version.AddItem(item1);
            version.AddItem(feature1);
            version.AddItem(bug1);
            Assert.AreEqual(1, version.PriorityCount(Priority.High));
        }

    }
}