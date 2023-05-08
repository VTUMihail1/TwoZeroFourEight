using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Interfaces
{
    public interface IGameMoves
    {
        void Up(IScore score, int[,] array);
        void Down(IScore score, int[,] array);
        void Right(IScore score, int[,] array);
        void Left(IScore score, int[,] array);

    }
}
