namespace TwoZeroFourEight.Frontend.Score.Interfaces
{
    public interface IScoreService
    {

        int ManageCurrentScore { get; set; }

        int ManageLastScore { get; set; }

        int HighestTileScore { get; set; }

        int ManageBestScore { get; set; }

    }
}

