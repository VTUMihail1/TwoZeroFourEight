using TwoZeroFourEight.Services.Interfaces;

namespace TwoZeroFourEight.Services.Classes
{
    public class AddRandomManager : IAddRandomManager
	{
		private readonly IAddRandomService _addRandom;
        private int[,] arrayClone;
        public AddRandomManager(IAddRandomService addRandom)
        {
            _addRandom = addRandom;
        }
		public void AddManage(int[,] array)
		{
            if (arrayClone == null || !array.Cast<int>().SequenceEqual(arrayClone.Cast<int>()))
            {
				if(array.Cast<int>().All(tile => tile == 0))
				{
					_addRandom.AddRandom(array);
				}
				_addRandom.AddRandom(array);
				arrayClone = array.Clone() as int[,];
            }
        }
	}
}

