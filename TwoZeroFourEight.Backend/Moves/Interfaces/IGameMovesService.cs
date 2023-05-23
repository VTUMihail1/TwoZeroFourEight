namespace TwoZeroFourEight.Backend.Moves.Interfaces
{
    public interface IGameMovesService
    {

        void MoveUp(int[,] array);

        void MoveDown(int[,] array);

        void MoveRight(int[,] array);

        void MoveLeft(int[,] array);

    }
}
