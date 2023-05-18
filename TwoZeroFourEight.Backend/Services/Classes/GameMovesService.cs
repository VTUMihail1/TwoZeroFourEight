using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Backend.Services.Classes
{
    public class GameMovesService : IGameMovesService
    {
        private int sum;
        
        private int currentIndex;

        private int currentNumber;

        private bool elementsAreEqual;

        private bool currentElementIsZero;

        private bool currentElementIsNotZero;

        private IScoreService _scoreService;

        public GameMovesService(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }


        public void MoveLeft(int[,] array)
        {

            for (int i = 0; i < StaticData.size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < StaticData.size; j++)
                {
                    currentElementIsNotZero = array[i, j] != StaticData.emptySpot;

                    if (currentElementIsNotZero)
                    {
                        elementsAreEqual = currentNumber == array[i, j];
                        currentElementIsZero = currentNumber == StaticData.emptySpot;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;

							array[i, currentIndex++] = sum;

                            _scoreService.ManageCurrentScore += currentNumber;

                            currentNumber = StaticData.emptySpot;
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

                        array[i, j] = StaticData.emptySpot;
                    }
                }

                currentElementIsZero = currentNumber == StaticData.emptySpot;

                if (currentElementIsZero)
                {
                    array[i, currentIndex] = currentNumber;
                }
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
                    currentElementIsNotZero = array[j, i] != StaticData.emptySpot;

                    if (currentElementIsNotZero)
                    {
                        elementsAreEqual = currentNumber == array[j, i];

                        currentElementIsZero = currentNumber == StaticData.emptySpot;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;

                            array[currentIndex++, i] = sum;

                            _scoreService.ManageCurrentScore += currentNumber;

                            currentNumber = StaticData.emptySpot;
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

                        array[j, i] = StaticData.emptySpot;
                    }
                }

                currentElementIsZero = currentNumber == StaticData.emptySpot;

                if (!currentElementIsZero)
                {
                    array[currentIndex, i] = currentNumber;
                }

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
                    currentElementIsNotZero = array[i, j] != StaticData.emptySpot;

                    if (currentElementIsNotZero)
                    {
                        elementsAreEqual = currentNumber == array[i, j];

                        currentElementIsZero = currentNumber == StaticData.emptySpot;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;
                            array[i, currentIndex--] = sum;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = StaticData.emptySpot;
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

                        array[i, j] = StaticData.emptySpot;
                    }
                }

                currentElementIsZero = currentNumber == StaticData.emptySpot;

                if (!currentElementIsZero)
                {
                    array[i, currentIndex] = currentNumber;
                }

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
                    currentElementIsNotZero = array[j, i] != StaticData.emptySpot;

                    if (currentElementIsNotZero)
                    {
                        elementsAreEqual = currentNumber == array[j, i];

                        currentElementIsZero = currentNumber == StaticData.emptySpot;

						if (elementsAreEqual)
                        {
                            sum = currentNumber + currentNumber;
                            array[currentIndex--, i] = sum;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = StaticData.emptySpot;
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

                        array[j, i] = StaticData.emptySpot;
                    }
                }

                currentElementIsZero = currentNumber == StaticData.emptySpot;

                if (!currentElementIsZero)
                {
                    array[currentIndex, i] = currentNumber;
                }

            }
        }
    }
}

