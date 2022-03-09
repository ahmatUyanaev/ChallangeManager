using ChallengeManager.Common.Configuration.Manager;
using NUnit.Framework;

namespace ChallangeManager.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var res = Configuration.GetDbConnection();
        }
    }
}