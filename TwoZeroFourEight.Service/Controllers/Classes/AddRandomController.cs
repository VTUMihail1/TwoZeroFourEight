using TwoZeroFourEight.Backend.Services.Interfaces;
using TwoZeroFourEight.Backend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class AddRandomController : IAddRandomController
    {
        private readonly IAddRandomService _addRandomService;
        private int[,] arrayClone;

        public AddRandomController(IAddRandomService addRandomService)
        {
            _addRandomService = addRandomService;
        }
        public void Add(int[,] array)
        {
            if (arrayClone == null || !array.Cast<int>().SequenceEqual(arrayClone.Cast<int>()))
            {
                if (array.Cast<int>().All(tile => tile == 0))
                {
                    _addRandomService.AddRandomElement(array);
                }
                _addRandomService.AddRandomElement(array);
                arrayClone = array.Clone() as int[,];
            }
        }
    }
}

