namespace TwoZeroFourEight.Services.Interfaces
{
    public interface IGameMoves
    {
        void Up(int[,] array);
        void Down(int[,] array);
        void Right(int[,] array);
        void Left(int[,] array);

    }
}
