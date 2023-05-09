using TwoZeroFourEight.LoggerFolder.Interfaces;
using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.TwoZeroFourEightFolder.Classes
{
    public class PrintResult : IPrintResult
	{
		private readonly IPrintState _state;
		private readonly ILogger _logger;
		private readonly IScore _score;
		public PrintResult(IPrintState state, ILogger logger, IScore score)
		{
			_state = state;
			_logger = logger;
			_score = score;
		}
		public bool GameOverPrint(int size)
		{
			int lowestScore = 0;
			if (_score.ManageBestScore != lowestScore)
			{
				int maxTile = 2048;
				string message = _score.HighestTileScore == maxTile
					? _state.YouWon(size)
					: _state.YouLost(size);
				_logger.Clear();
				_logger.WriteLine(message);
				_logger.ReadKey();
				_logger.Clear();
				return true;
			}
			return false;
		}
	}
}

