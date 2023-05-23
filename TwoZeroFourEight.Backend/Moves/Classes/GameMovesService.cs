using TwoZeroFourEight.Backend.Moves.Interfaces;
using TwoZeroFourEight.Frontend.Score.Interfaces;

namespace TwoZeroFourEight.Backend.Moves.Classes
{
    public class GameMovesService : IGameMovesService
    {
        private int currentIndex;

        private int currentNumber;

        private readonly IScoreController _scoreController;

        private readonly Func<int, bool> elementIsNotZero;

        private readonly Func<int, int, bool> elementsAreEqual;

        public GameMovesService(IScoreController scoreController)
        {
            _scoreController = scoreController;

            elementIsNotZero = number => number != StaticData.emptySpot;
            elementsAreEqual = (numberOne, numberTwo) => numberOne == numberTwo;
        }

        public void MoveLeft(int[,] array)
        {

            for (int i = 0; i < StaticData.size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < StaticData.size; j++)
                {

                    if (!elementIsNotZero(array[i, j]))
                    {
                        continue;
                    }
                    if (elementsAreEqual(currentNumber, array[i, j]))
                    {
                        array[i, currentIndex++] = currentNumber + currentNumber;

                        _scoreController.UpdateCurrentScore(currentNumber);

                        currentNumber = StaticData.emptySpot;
                    }

                    else if (!elementIsNotZero(currentNumber))
                    {
                        currentNumber = array[i, j];
                    }

                    else
                    {
                        array[i, currentIndex++] = currentNumber;
                        currentNumber = array[i, j];
                    }

                    array[i, j] = StaticData.emptySpot;
                }

                if (elementIsNotZero(currentNumber))
                {
                    array[i, currentIndex] = currentNumber;
                }

                _scoreController.UpdateBestScore();
            }
        }
        public void MoveUp(int[,] array)
        {

            for (int i = 0; i < StaticData.size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < StaticData.size; j++)
                {

                    if (!elementIsNotZero(array[j, i]))
                    {
                        continue;
                    }
                    if (elementsAreEqual(currentNumber, array[j, i]))
                    {
                        array[currentIndex++, i] = currentNumber + currentNumber;

                        _scoreController.UpdateCurrentScore(currentNumber);

                        currentNumber = StaticData.emptySpot;
                    }

                    else if (!elementIsNotZero(currentNumber))
                    {
                        currentNumber = array[j, i];
                    }

                    else
                    {
                        array[currentIndex++, i] = currentNumber;
                        currentNumber = array[j, i];
                    }

                    array[j, i] = StaticData.emptySpot;
                }

                if (elementIsNotZero(currentNumber))
                {
                    array[currentIndex, i] = currentNumber;
                }

                _scoreController.UpdateBestScore();
            }

        }
        public void MoveRight(int[,] array)
        {

            for (int i = 0; i < StaticData.size; i++)
            {
                currentIndex = StaticData.size - 1;
                currentNumber = 0;

                for (int j = StaticData.size - 1; j >= 0; j--)
                {

                    if (!elementIsNotZero(array[i, j]))
                    {
                        continue;
                    }
                    if (elementsAreEqual(currentNumber, array[i, j]))
                    {
                        array[i, currentIndex--] = currentNumber + currentNumber;

                        _scoreController.UpdateCurrentScore(currentNumber);

                        currentNumber = StaticData.emptySpot;
                    }

                    else if (!elementIsNotZero(currentNumber))
                    {
                        currentNumber = array[i, j];
                    }

                    else
                    {
                        array[i, currentIndex--] = currentNumber;

                        currentNumber = array[i, j];
                    }

                    array[i, j] = StaticData.emptySpot;
                }

                if (elementIsNotZero(currentNumber))
                {
                    array[i, currentIndex] = currentNumber;
                }

                _scoreController.UpdateBestScore();
            }
        }
        public void MoveDown(int[,] array)
        {

            for (int i = 0; i < StaticData.size; i++)
            {
                currentIndex = StaticData.size - 1;
                currentNumber = 0;

                for (int j = StaticData.size - 1; j >= 0; j--)
                {

                    if (!elementIsNotZero(array[j, i]))
                    {
                        continue;
                    }
                    if (elementsAreEqual(currentNumber, array[j, i]))
                    {
                        array[currentIndex--, i] = currentNumber + currentNumber;

                        _scoreController.UpdateCurrentScore(currentNumber);

                        currentNumber = StaticData.emptySpot;
                    }

                    else if (!elementIsNotZero(currentNumber))
                    {
                        currentNumber = array[j, i];
                    }

                    else
                    {
                        array[currentIndex--, i] = currentNumber;

                        currentNumber = array[j, i];
                    }

                    array[j, i] = StaticData.emptySpot;
                }

                if (elementIsNotZero(currentNumber))
                {
                    array[currentIndex, i] = currentNumber;
                }

                _scoreController.UpdateBestScore();
            }
        }
    }
}

