namespace TwoZeroFourEight.Frontend.Controllers.Interfaces
{
    public interface IScoreController
    {
        void Calculate(int highestTile);
        void UpdateBestScore();
        void UpdateCurrentScore(int number);
        void UpdateLastScore(int number);
    }
}