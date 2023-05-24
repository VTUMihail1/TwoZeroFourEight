using System.Drawing;
using TwoZeroFourEight.Frontend.AddColor.Interfaces;
using TwoZeroFourEight.Frontend.Board.Interfaces;
using TwoZeroFourEight.Frontend.Logger.Interfaces;

namespace TwoZeroFourEight.Frontend.Board.Classes
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


        public void Print(int[,] array)
        {
            string fullRow = string.Concat(Enumerable.Repeat("-", StaticData.size * 9 + 1));

            for (int i = 0; i < StaticData.size; i++)
            {
                _loggerService.WriteLine(fullRow);
                _loggerService.Write(StaticData.startOfRow);

                for (int j = 0; j < StaticData.size; j++)
                {
                    _addColorService.AddColor(array[i, j]);

                    _loggerService.Write(StaticData.midEndOfRow);
                }

                _loggerService.WriteLine();
            }
            _loggerService.WriteLine(fullRow);

        }
    }
}

