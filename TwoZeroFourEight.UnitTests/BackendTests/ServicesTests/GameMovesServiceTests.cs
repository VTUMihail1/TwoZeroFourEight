using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Backend.Services.Classes;
using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.UnitTests.BackendTests.ServicesTests
{
    [TestFixture]
    public class GameMovesServiceTests
    {
        private IGameMovesService gameMovesService;

        [SetUp]
        public void SetUp()
        {
            var scoreService = new Mock<IScoreService>();

            gameMovesService = new GameMovesService(scoreService.Object);
        }


        [Test]
        public void MoveRight_MoveTilesToRightAndMerges_CorrectlyMergesAndShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {0,0,4,4 },
                {0,0,4,4 },
                {0,0,4,4 },
                {0,0,4,4 }
            };

            gameMovesService.MoveRight(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveRight_MoveTilesToRight_CorrectlyShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {4,0,0,0 },
                {4,0,0,0 },
                {4,0,0,0 },
                {4,0,0,0 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {0,0,0,4 },
                {0,0,0,4 },
                {0,0,0,4 },
                {0,0,0,4 }
            };

            gameMovesService.MoveRight(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveRight_MaxTiles_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };

            gameMovesService.MoveRight(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveLeft_MoveTilesToLeftAndMerges_CorrectlyMergesAndShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,4,0,0 },
                {4,4,0,0 },
                {4,4,0,0 },
                {4,4,0,0 }
            };

            gameMovesService.MoveLeft(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveLeft_MoveTilesToLeft_CorrectlyShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,4 },
                {0,0,0,4 },
                {0,0,0,4 },
                {0,0,0,4 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,0,0,0 },
                {4,0,0,0 },
                {4,0,0,0 },
                {4,0,0,0 }
            };

            gameMovesService.MoveLeft(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveLeft_MaxTiles_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };

            gameMovesService.MoveRight(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveUp_MoveTilesToTheTopAndMerges_CorrectlyMergesAndShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,4,4,4 },
                {4,4,4,4 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            gameMovesService.MoveUp(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveUp_MoveTilesToTheTop_CorrectlyShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {4,4,4,4 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,4,4,4 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };

            gameMovesService.MoveUp(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveUp_MaxTiles_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };

            gameMovesService.MoveUp(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveDown_MoveTilesToTheBottomAndMerges_CorrectlyMergesAndShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 },
                {2,2,2,2 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {4,4,4,4 },
                {4,4,4,4 }
            };

            gameMovesService.MoveDown(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveDown_MoveTilesToTheBottom_CorrectlyShiftsTiles()
        {
            int[,] array = new int[4, 4]
            {
                {4,4,4,4 },
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {0,0,0,0 },
                {0,0,0,0 },
                {0,0,0,0 },
                {4,4,4,4 }
            };

            gameMovesService.MoveDown(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }


        [Test]
        public void MoveDown_MaxTiles_ReturnsTheSameArray()
        {
            int[,] array = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };
            int[,] arrayResult = new int[4, 4]
            {
                {4,2,4,2 },
                {2,4,2,4 },
                {4,2,4,2 },
                {2,4,2,4 }
            };

            gameMovesService.MoveDown(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }

    }
}
