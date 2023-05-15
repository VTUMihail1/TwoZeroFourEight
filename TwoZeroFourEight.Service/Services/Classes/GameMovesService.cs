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
        private int currentIndex;
        private int currentNumber;
        public void MoveLeft(int[,] array)
        {
            _size = array.GetLength(0);
            for (int i = 0; i < _size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < _size; j++)
                {
                    if (array[i, j] != 0)
                    {
                        if (currentNumber == array[i, j])
                        {
                            array[i, currentIndex++] = currentNumber * 2;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = 0;
                        }
                        else if (currentNumber == 0)
                        {
                            currentNumber = array[i, j];
                        }
                        else
                        {
                            array[i, currentIndex++] = currentNumber;
                            currentNumber = array[i, j];
                        }
                        array[i, j] = 0;
                    }
                }
                if (currentNumber != 0)
                {
                    array[i, currentIndex] = currentNumber;
                }
            }
        }
        public void MoveUp(int[,] array)
        {
            _size = array.GetLength(0);
            for (int i = 0; i < _size; i++)
            {
                currentIndex = 0;
                currentNumber = 0;

                for (int j = 0; j < _size; j++)
                {
                    if (array[j, i] != 0)
                    {
                        if (currentNumber == array[j, i])
                        {
                            array[currentIndex++, i] = currentNumber * 2;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = 0;
                        }
                        else if (currentNumber == 0)
                        {
                            currentNumber = array[j, i];
                        }
                        else
                        {
                            array[currentIndex++, i] = currentNumber;
                            currentNumber = array[j, i];
                        }
                        array[j, i] = 0;
                    }
                }
                if (currentNumber != 0)
                {
                    array[currentIndex, i] = currentNumber;
                }
            }
        }
        public void MoveRight(int[,] array)
        {
            _size = array.GetLength(0);
            for (int i = 0; i < _size; i++)
            {
                currentIndex = _size - 1;
                currentNumber = 0;

                for (int j = _size - 1; j >= 0; j--)
                {
                    if (array[i, j] != 0)
                    {
                        if (currentNumber == array[i, j])
                        {
                            array[i, currentIndex--] = currentNumber * 2;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = 0;
                        }
                        else if (currentNumber == 0)
                        {
                            currentNumber = array[i, j];
                        }
                        else
                        {
                            array[i, currentIndex--] = currentNumber;
                            currentNumber = array[i, j];
                        }
                        array[i, j] = 0;
                    }
                }
                if (currentNumber != 0)
                {
                    array[i, currentIndex] = currentNumber;
                }
            }
        }
        public void MoveDown(int[,] array)
        {
            _size = array.GetLength(0);
            for (int i = 0; i < _size; i++)
            {
                currentIndex = _size - 1;
                currentNumber = 0;

                for (int j = _size - 1; j >= 0; j--)
                {
                    if (array[j, i] != 0)
                    {
                        if (currentNumber == array[j, i])
                        {
                            array[currentIndex--, i] = currentNumber * 2;
                            _scoreService.ManageCurrentScore += currentNumber;
                            currentNumber = 0;
                        }
                        else if (currentNumber == 0)
                        {
                            currentNumber = array[j, i];
                        }
                        else
                        {
                            array[currentIndex--, i] = currentNumber;
                            currentNumber = array[j, i];
                        }
                        array[j, i] = 0;
                    }
                }
                if (currentNumber != 0)
                {
                    array[currentIndex, i] = currentNumber;
                }
            }
        }
    }
}

