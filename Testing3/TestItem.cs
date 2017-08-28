using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AgileManager
{
    [TestFixture]
    public class TestItem
    {
        Item item;
        List<Item> items;

        [SetUp]
        public void Init()
        {
            item = new Item("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium);
        }

        [Test]
        public void TestHasTitle()
        {
            Assert.AreEqual("Timestamp for Audit Trail", item.Title);
        }

        [Test]
        public void TestHasComponent()
        {
            Assert.AreEqual("Activity Log", item.Component);
        }

        [Test]
        public void TestHasDescription()
        {
            Assert.AreEqual("Auto time and user ID stamp", item.Description);
        }

        [Test]
        public void TestHasDevEffort()
        {
            Assert.AreEqual(5, item.DevEffort);
        }

        [Test]
        public void TestHasTestEffort()
        {
            Assert.AreEqual(3, item.TestEffort);
        }

        [Test]
        public void TestHasStakeholder()
        {
            Assert.AreEqual(Stakeholder.Owner, item.Requestor);
        }

        [Test]
        public void TestHasPriority()
        {
            Assert.AreEqual(Priority.Medium, item.Priority);
        }

        [Test]
        public void TestCanCalcTotalEffort()
        {
            Assert.AreEqual(8, item.CalcTotalEffort());
        }

    }
}
