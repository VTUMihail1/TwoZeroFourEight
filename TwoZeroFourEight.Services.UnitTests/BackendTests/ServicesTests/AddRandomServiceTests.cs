using NUnit.Framework;
using TwoZeroFourEight.Backend.Services.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ServicesTests
{
    [TestFixture]
    public class AddRandomServiceTests
    {
        private IAddRandomService addRandomService;

        [SetUp]
        public void SetUp()
        {
            addRandomService = new AddRandomService(new Random());
        }


        [Test]
        public void AddRandomElement_WhenArrayIsntAtMaxCapacity_AddOneElementToTheArray()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            addRandomService.AddRandomElement(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(3));
        }


        [Test]
        public void AddRandomElement_WhenArrayIsAtMaxCapacity_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            addRandomService.AddRandomElement(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(16));
        }
    }
}
