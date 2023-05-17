using TwoZeroFourEight.Frontend.Services.Interfaces;

namespace TwoZeroFourEight.Frontend.Services.Classes
{
    public class PrintBoardService : IPrintBoardService
    {
        private readonly ILoggerService _loggerService;

        private readonly IAddColorService _addColorService;

        public PrintBoardService(ILoggerService loggerService, IAddColorService addColorService)
        {
            _loggerService = loggerService;

            _addColorService = addColorService;
        }


        public void PrintBoard(int[,] array)
        {
            int size = array.GetLength(0);

            string fullRow = string.Concat(Enumerable.Repeat("-", size * 9 + 1));

            string startOfRow = "|  ";

            string midEndOfRow = "  |  ";

            for (int i = 0; i < size; i++)
            {
                _loggerService.WriteLine(fullRow);

                _loggerService.Write(startOfRow);

                for (int j = 0; j < size; j++)
                {
                    _addColorService.AddColor(array[i, j]);

                    _loggerService.Write(midEndOfRow);
                }

                _loggerService.WriteLine();
            }
            _loggerService.WriteLine(fullRow);

        }
    }
}

