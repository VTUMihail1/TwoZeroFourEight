using TwoZeroFourEight.LoggerFolder.Interfaces;
using TwoZeroFourEight.ServicesFolder.Interfaces;

namespace TwoZeroFourEight.ServicesFolder.Classes
{
	class AddColor : IAddColor
	{
		public void AddColors(ILogger logger, int value)
		{
			ConsoleColor color;

			if (value == 2)
			{
				color = ConsoleColor.Red;
			}
			else if (value == 4)
			{
				color = ConsoleColor.Green;
			}
			else if (value == 8)
			{
				color = ConsoleColor.Yellow;
			}
			else if (value == 16)
			{
				color = ConsoleColor.Magenta;
			}
			else if (value == 32)
			{
				color = ConsoleColor.Cyan;
			}
			else if (value == 64)
			{
				color = ConsoleColor.Blue;
			}
			else if (value == 128)
			{
				color = ConsoleColor.DarkRed;
			}
			else if (value == 256)
			{
				color = ConsoleColor.DarkGreen;
			}
			else if (value == 512)
			{
				color = ConsoleColor.DarkYellow;
			}
			else if (value == 1024)
			{
				color = ConsoleColor.DarkMagenta;
			}
			else if (value == 2048)
			{
				color = ConsoleColor.DarkCyan;
			}
			else if (value == 4096)
			{
				color = ConsoleColor.DarkBlue;
			}
			else if (value == 8192)
			{
				color = ConsoleColor.Gray;
			}
			else
			{
				color = ConsoleColor.White;
			}

			Console.ForegroundColor = color;
			logger.Write(value.ToString());
			Console.ResetColor();
		}
	}
}

