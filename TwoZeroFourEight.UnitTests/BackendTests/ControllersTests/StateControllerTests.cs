using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Backend.Add.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Classes;
using TwoZeroFourEight.Backend.State.Classes;
using TwoZeroFourEight.Backend.State.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ControllersTests
{
    [TestFixture]
    public class StateControllerTests
    {
        private Mock<IRestartGameService> restartService;

        private Mock<IResultController> resultController;

        private Mock<IAddRandomController> addRandomController;

        private IStateController stateController;

        [SetUp]
        public void SetUp()
        {
            restartService = new Mock<IRestartGameService>();

            resultController = new Mock<IResultController>();

            addRandomController = new Mock<IAddRandomController>();

            stateController = new StateController(resultController.Object, addRandomController.Object, restartService.Object);
        }


        [Test]
        public void InputStates_ConsoleKeyIsRightOrGameIsOver_RestartsTheGame()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.R, false, false, false);

            stateController.InputStates(cki, It.IsAny<int[,]>());

            restartService.Verify(x => x.Restart(It.IsAny<int[,]>()), Times.Exactly(1));
        }


        //[Test]
        //public void InputStates_ConsoleKeyIsEscape_ExitsTheGame()
        //{
        //    ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.Escape, false, false, false);

        //    stateController.InputStates(cki, It.IsAny<int[,]>());

        //    Assert.Throws<Exception>(() => stateController.InputStates(cki, It.IsAny<int[,]>()));
        //}


        [Test]
        [TestCase(ConsoleKey.UpArrow)]
        [TestCase(ConsoleKey.DownArrow)]
        [TestCase(ConsoleKey.RightArrow)]
        [TestCase(ConsoleKey.LeftArrow)]
        public void InputStates_ConsoleKeyIsAArrowKey_AddsAElementToTheCollection(ConsoleKey key)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', key, false, false, false);

            stateController.InputStates(cki, It.IsAny<int[,]>());

            addRandomController.Verify(x => x.Add(It.IsAny<int[,]>()), Times.Exactly(1));
        }

    }
}
