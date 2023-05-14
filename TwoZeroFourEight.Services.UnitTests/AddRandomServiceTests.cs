using NUnit.Framework;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;
using TwoZeroFourEight.UserInterfaces.Classes;

namespace TwoZeroFourEight.Services.UnitTests
{
    [TestFixture]
    public class AddRandomServiceTests
    {
        private IAddRandomService service;
        [SetUp] 
        public void SetUp() 
        {
            service = new AddRandomService(new Random());
        }
        [Test]
        public void AddRandom_WhenArrayIsntAtMaxCapacity_AddOneElementToTheArray()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            service.AddRandom(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(3));
        }
        [Test]
        public void AddRandom_WhenArrayIsAtMaxCapacity_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            service.AddRandom(array);

            Assert.That(array.Cast<int>().Count(num => num == 2), Is.EqualTo(16));
        }
    }
}
