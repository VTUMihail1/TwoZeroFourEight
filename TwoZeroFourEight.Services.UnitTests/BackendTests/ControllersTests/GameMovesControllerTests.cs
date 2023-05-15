using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Backend.Controllers.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ControllersTests
{
    [TestFixture]
    public class GameMovesControllerTests
    {
        private Mock<IGameMovesService> gameMovesService;
        private IGameMovesController gameMovesController;
        [SetUp]
        public void SetUp()
        {
            gameMovesService = new Mock<IGameMovesService>();
            gameMovesController = new GameMovesController(gameMovesService.Object);
        }
        [Test]
        public void InputMoves_ConsoleKeyIsRight_CallsTheMoveRightMethod()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.RightArrow, false, false, false);

            gameMovesController.InputMoves(cki, It.IsAny<int[,]>());

            gameMovesService.Verify(x => x.MoveRight(It.IsAny<int[,]>()), Times.Exactly(1));
        }
        [Test]
        public void InputMoves_ConsoleKeyIsLeft_CallsTheMoveLeftMethod()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.LeftArrow, false, false, false);

            gameMovesController.InputMoves(cki, It.IsAny<int[,]>());

            gameMovesService.Verify(x => x.MoveLeft(It.IsAny<int[,]>()), Times.Exactly(1));
        }
        [Test]
        public void InputMoves_ConsoleKeyIsUp_CallsTheMoveUpMethod()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.UpArrow, false, false, false);

            gameMovesController.InputMoves(cki, It.IsAny<int[,]>());

            gameMovesService.Verify(x => x.MoveUp(It.IsAny<int[,]>()), Times.Exactly(1));
        }
        [Test]
        public void InputMoves_ConsoleKeyIsDown_CallsTheMoveDownMethod()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.DownArrow, false, false, false);

            gameMovesController.InputMoves(cki, It.IsAny<int[,]>());

            gameMovesService.Verify(x => x.MoveDown(It.IsAny<int[,]>()), Times.Exactly(1));
        }
    }
}
