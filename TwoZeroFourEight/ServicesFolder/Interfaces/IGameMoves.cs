using TwoZeroFourEight.TwoZeroFourEightFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Interfaces
{
    public interface IGameMoves
    {
        void Up(int[,] array);
        void Down(int[,] array);
        void Right(int[,] array);
        void Left(int[,] array);

    }
}
