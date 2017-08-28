using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AgileManager
{
    [TestFixture]
    public class TestFeature
    {
        Feature feature;
        List<Item> items;

        [SetUp]
        public void Init()
        {
            feature = new Feature("Timestamp for Audit Trail", "Activity Log", "Auto time and user ID stamp", 5, 3, Stakeholder.Owner, Priority.Medium, Reason.Regulatory);
        }

        [Test]
        public void TestHasTitle()
        {
            Assert.AreEqual("Timestamp for Audit Trail", feature.Title);
        }

        [Test]
        public void TestHasComponent()
        {
            Assert.AreEqual("Activity Log", feature.Component);
        }

        [Test]
        public void TestHasDescription()
        {
            Assert.AreEqual("Auto time and user ID stamp", feature.Description);
        }

        [Test]
        public void TestHasDevEffort()
        {
            Assert.AreEqual(5, feature.DevEffort);
        }

        [Test]
        public void TestHasTestEffort()
        {
            Assert.AreEqual(3, feature.TestEffort);
        }

        [Test]
        public void TestHasStakeholder()
        {
            Assert.AreEqual(Stakeholder.Owner, feature.Requestor);
        }

        [Test]
        public void TestHasPriority()
        {
            Assert.AreEqual(Priority.Medium, feature.Priority);
        }

        [Test]
        public void TestHasReason()
        {
            Assert.AreEqual(Reason.Regulatory, feature.Reason);
        }

    }
}
