using Moq;
using NUnit.Framework;
using TwoZeroFourEight.Services.Classes;
using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.UnitTests
{
    public class MovesManagerTests
    {
        private IMovesManager movesManager;
        [SetUp]
        public void SetUp()
        {
            IScore score = new Score();
            IGameMoves moves = new GameMoves(score);
            movesManager = new MovesManager(moves);

        }
        [Test]
        public void Start_ConsoleKeyIsRight_MovesAllTilesToTheRight()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.RightArrow, false, false, false);
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

            movesManager.CheckMoves(cki,array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Start_ConsoleKeyIsLeft_MovesAllTilesToTheRight()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.LeftArrow, false, false, false);
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

            movesManager.CheckMoves(cki, array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Start_ConsoleKeyIsUp_MovesAllTilesToTheRight()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.UpArrow, false, false, false);
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

            movesManager.CheckMoves(cki, array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
        [Test]
        public void Start_ConsoleKeyIsDown_MovesAllTilesToTheRight()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo('\0', ConsoleKey.DownArrow, false, false, false);
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

            movesManager.CheckMoves(cki, array);

            Assert.That(array, Is.EqualTo(arrayResult));
        }
    }
}
