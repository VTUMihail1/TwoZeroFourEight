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
            bool arrayChanged = !array.Cast<int>().SequenceEqual(arrayClone.Cast<int>());

            bool arrayIsEmpty = array.Cast<int>().All(tile => tile == 0);

			if (arrayClone == null || arrayChanged)
            {
                
                if (arrayIsEmpty)
                {
                    _addRandomService.AddRandomElement(array);
                }

                _addRandomService.AddRandomElement(array);

                arrayClone = array.Clone() as int[,];
            }

        }

    }
}

