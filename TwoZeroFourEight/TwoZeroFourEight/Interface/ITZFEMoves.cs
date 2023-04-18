using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoZeroFourEight.TwoZeroFourEight.Interface
{
    public interface ITZFEMoves : IGetArray
    {
        void Up(ref int score);
        void Down(ref int score);
        void Right(ref int score);
        void Left(ref int score);

	}
}
