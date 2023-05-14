using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.UnitTests
{
    [TestFixture]
    public class GameMovesTests
    {
        private IGameMoves moves;
        [SetUp]
        public void SetUp()
        {
            IScore score = new Score();
            moves = new GameMoves(score);
        }
        [Test]
        public void Right_MoveTilesToRightAndMerges_CorrectlyMergesAndShiftsTiles()
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

            moves.Right(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Right_MoveTilesToRight_CorrectlyShiftsTiles()
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

            moves.Right(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Right_MaxTiles_ReturnsTheSameArray()
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

            moves.Right(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Left_MoveTilesToLeftAndMerges_CorrectlyMergesAndShiftsTiles()
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

            moves.Left(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Left_MoveTilesToLeft_CorrectlyShiftsTiles()
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

            moves.Left(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Left_MaxTiles_ReturnsTheSameArray()
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

            moves.Left(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Up_MoveTilesToTheTopAndMerges_CorrectlyMergesAndShiftsTiles()
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

            moves.Up(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Up_MoveTilesToTheTop_CorrectlyShiftsTiles()
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

            moves.Up(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Up_MaxTiles_ReturnsTheSameArray()
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

            moves.Up(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Down_MoveTilesToTheBottomAndMerges_CorrectlyMergesAndShiftsTiles()
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

            moves.Down(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Down_MoveTilesToTheBottom_CorrectlyShiftsTiles()
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

            moves.Down(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Down_MaxTiles_ReturnsTheSameArray()
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

            moves.Down(array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
    }
}
