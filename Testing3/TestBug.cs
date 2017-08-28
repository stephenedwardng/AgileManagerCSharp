using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AgileManager
{
    [TestFixture]
    public class TestBug
    {
        Bug bug;
        List<Item> items;

        [SetUp]
        public void Init()
        {
            bug = new Bug("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium, Severity.Critical);
        }

        [Test]
        public void TestHasTitle()
        {
            Assert.AreEqual("Timestamp for Audit Trail", bug.Title);
        }

        [Test]
        public void TestHasComponent()
        {
            Assert.AreEqual("Activity Log", bug.Component);
        }

        [Test]
        public void TestHasDescription()
        {
            Assert.AreEqual("Auto time and user ID stamp", bug.Description);
        }

        [Test]
        public void TestHasDevEffort()
        {
            Assert.AreEqual(5, bug.DevEffort);
        }

        [Test]
        public void TestHasTestEffort()
        {
            Assert.AreEqual(3, bug.TestEffort);
        }

        [Test]
        public void TestHasStakeholder()
        {
            Assert.AreEqual(Stakeholder.Owner, bug.Requestor);
        }

        [Test]
        public void TestHasPriority()
        {
            Assert.AreEqual(Priority.Medium, bug.Priority);
        }

        [Test]
        public void TestHasSeverity()
        {
            Assert.AreEqual(Severity.Critical, bug.Severity);
        }

    }
}
