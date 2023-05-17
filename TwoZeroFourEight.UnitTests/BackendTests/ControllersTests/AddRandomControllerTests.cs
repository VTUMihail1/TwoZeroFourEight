using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Classes;
using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ControllersTests
{
    [TestFixture]
    public class AddRandomControllerTests
    {
        private Mock<IAddRandomService> addRandomService;

        private IAddRandomController addRandomController;

        [SetUp]
        public void SetUp()
        {
            addRandomService = new Mock<IAddRandomService>();

            addRandomController = new AddRandomController(addRandomService.Object);
        }


        [Test]
        public void Add_WhenArrayIsEmpty_ExcecutesTheAddMethodTwice()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            addRandomController.Add(array);

            addRandomService.Verify(x => x.AddRandomElement(array), Times.Exactly(2));
        }


        [Test]
        public void Add_WhenArrayHasOneOrMoreElementsAndIsntAtMaxCapacity_ExcecutesTheAddMethodOnce()
        {
            int[,] array = new int[4, 4]
            {
                {2,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            addRandomController.Add(array);

            addRandomService.Verify(x => x.AddRandomElement(array), Times.Exactly(1));
        }


        [Test]
        public void Add_WhenArrayIsAtMaxCapacity_CallsTheAddMethodButDoesntExcecuteIt()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };

            addRandomController.Add(array);

            addRandomService.Verify(x => x.AddRandomElement(array), Times.Exactly(1));
        }
    }
}
