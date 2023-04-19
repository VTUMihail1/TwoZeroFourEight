using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TwoZeroFourEight.TwoZeroFourEight.Interface.Services
{
    public interface ITZFEMoves
    {
        void Up(int[,] array);
        void Down(int[,] array);
        void Right(int[,] array);
        void Left(int[,] array);

    }
}
