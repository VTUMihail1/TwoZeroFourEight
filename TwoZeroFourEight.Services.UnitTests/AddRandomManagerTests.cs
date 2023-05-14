using NUnit.Framework;
using Moq;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.UnitTests
{
    [TestFixture]
    public class AddRandomManagerTests
    {
        private IAddRandomManager manager;
        [SetUp]
        public void SetUp()
        {
            IAddRandomService service = new AddRandomService(new Random());
            manager = new AddRandomManager(service);
        }
        [Test]
        public void AddManage_WhenArrayIsEmpty_AddsTwoElementsToTheArray()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            manager.AddManage(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(2));
        }
        [Test]
        public void AddManage_WhenArrayHasOneOrMoreElements_AddsOneElementToTheArray()
        {
            int[,] array = new int[4, 4]
            {
                {2,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            manager.AddManage(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(2));
        }
        [Test]
        public void AddManage_WhenArrayIsAtMaxCapacity_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            manager.AddManage(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(16));
        }
    }
}
