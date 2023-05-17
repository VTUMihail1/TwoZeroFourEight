using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class GameMovesService : IGameMovesService
    {
        private IScoreService _scoreService;

        public GameMovesService(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        private int _size;

        private int sum;

        private int minValue;
        
        private int currentIndex;

        private int currentNumber;

        private bool elementsAreEqual;

        private bool currentElementIsZero;

        public void MoveLeft(int[,] array)
        {
            _size = array.GetLength(0);
            minValue = 0;

            for (int i = 0; i < _size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < _size; j++)
                {

                    if (array[i, j] != minValue)
                    {
                        elementsAreEqual = currentNumber == array[i, j];

                        currentElementIsZero = currentNumber == minValue;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;

							array[i, currentIndex++] = sum;

                            _scoreService.ManageCurrentScore += currentNumber;

                            currentNumber = minValue;
                        }


                        else if (currentElementIsZero)
                        {
                            currentNumber = array[i, j];
                        }


                        else
                        {
                            array[i, currentIndex++] = currentNumber;
                            currentNumber = array[i, j];
                        }

                        array[i, j] = minValue;
                    }
                }

                if (currentNumber != minValue)
                {
                    array[i, currentIndex] = currentNumber;
                }
            }
        }
        public void MoveUp(int[,] array)
        {
            _size = array.GetLength(0);
            minValue = 0;

            for (int i = 0; i < _size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < _size; j++)
                {

                    if (array[j, i] != minValue)
                    {
                        elementsAreEqual = currentNumber == array[j, i];

                        currentElementIsZero = currentNumber == minValue;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;

                            array[currentIndex++, i] = sum;

                            _scoreService.ManageCurrentScore += currentNumber;

                            currentNumber = minValue;
                        }

                        else if (currentElementIsZero)
                        {
                            currentNumber = array[j, i];
                        }

                        else
                        {
                            array[currentIndex++, i] = currentNumber;
                            currentNumber = array[j, i];
                        }

                        array[j, i] = minValue;
                    }
                }

                if (currentNumber != minValue)
                {
                    array[currentIndex, i] = currentNumber;
                }

            }

        }
        public void MoveRight(int[,] array)
        {
            _size = array.GetLength(0);
            minValue = 0;

            for (int i = 0; i < _size; i++)
            {
                currentIndex = _size - 1;
                currentNumber = 0;

                for (int j = _size - 1; j >= 0; j--)
                {

                    if (array[i, j] != minValue)
                    {
                        elementsAreEqual = currentNumber == array[i, j];

                        currentElementIsZero = currentNumber == minValue;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;
                            array[i, currentIndex--] = sum;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = minValue;
                        }

                        else if (currentElementIsZero)
                        {
                            currentNumber = array[i, j];
                        }

                        else
                        {
                            array[i, currentIndex--] = currentNumber;
                            currentNumber = array[i, j];
                        }

                        array[i, j] = minValue;
                    }
                }

                if (currentNumber != minValue)
                {
                    array[i, currentIndex] = currentNumber;
                }

            }
        }
        public void MoveDown(int[,] array)
        {
            _size = array.GetLength(0);
            minValue = 0;

            for (int i = 0; i < _size; i++)
            {
                currentIndex = _size - 1;
                currentNumber = 0;

                for (int j = _size - 1; j >= 0; j--)
                {

                    if (array[j, i] != minValue)
                    {
                        elementsAreEqual = currentNumber == array[j, i];

                        currentElementIsZero = currentNumber == minValue;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;
                            array[currentIndex--, i] = sum;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = minValue;
                        }

                        else if (currentElementIsZero)
                        {
                            currentNumber = array[j, i];
                        }

                        else
                        {
                            array[currentIndex--, i] = currentNumber;
                            currentNumber = array[j, i];
                        }

                        array[j, i] = minValue;
                    }
                }

                if (currentNumber != minValue)
                {
                    array[currentIndex, i] = currentNumber;
                }

            }
        }
    }
}

