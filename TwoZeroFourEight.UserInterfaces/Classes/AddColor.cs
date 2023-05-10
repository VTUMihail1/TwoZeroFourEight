using TwoZeroFourEight.UserInterface.Interfaces;

namespace TwoZeroFourEight.UserInterface.Classes
{
	public class AddColor : IAddColor
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
            else
            {
                color = ConsoleColor.White;
            }

            Console.ForegroundColor = color;
            string result = value.ToString().PadRight(4);
            logger.Write(result);
            Console.ResetColor();
        }
    }
}

