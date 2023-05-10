using TwoZeroFourEight.UserInterfaces.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
    public class PrintBoard : IPrintBoard
    {
        private readonly ILogger _logger;
        private readonly IAddColor _color;
        public PrintBoard(ILogger logger, IAddColor color)
        {
            _logger = logger;
            _color = color;
        }
        public void PrintGameBoard(int[,] array)
        {
            int size = array.GetLength(0);
            string fullRow = string.Concat(Enumerable.Repeat("-", size * 9 + 1));
            string startOfRow = "|  ";
            string midEndOfRow = "  |  ";
            for (int i = 0; i < size; i++)
            {
                _logger.WriteLine(fullRow);
                _logger.Write(startOfRow);
                for (int j = 0; j < size; j++)
                {
                    _color.AddColors(_logger, array[i, j]);
                    _logger.Write(midEndOfRow);
                }
                _logger.WriteLine();
            }
            _logger.WriteLine(fullRow);
        }
    }
}

