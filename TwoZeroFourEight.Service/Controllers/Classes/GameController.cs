using TwoZeroFourEight.Backend.Controllers.Interfaces;
using TwoZeroFourEight.Frontend.Controllers.Interfaces;

namespace TwoZeroFourEight.Backend.Controllers.Classes
{
    public class GameController : IGameController
    {
        private readonly IServicesController _servicesController;
        private readonly IUIController _uiController;

        public GameController(IServicesController servicesController, IUIController uiController)
        {
            _servicesController = servicesController;
            _uiController = uiController;
        }
        public void Start(int[,] array)
        {
            while (true)
            {
                _uiController.PrintGame(array);
                _servicesController.RunGame(array);
            }
        }
    }
}

