namespace TwoZeroFourEight.Services.Interfaces
{
    public interface IScore
    {
        int ManageScore { get; set; }
        int ManageLastScore { get; set; }
        int HighestTileScore { get; set; }
        int ManageBestScore { get; set; }
    }
}

