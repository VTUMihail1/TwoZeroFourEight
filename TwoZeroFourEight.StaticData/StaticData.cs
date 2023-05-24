/// <summary>
/// Static data class containing game-related constants and settings.
/// </summary>
public static class StaticData
{
    /// <summary>
    /// The size of the game board.
    /// </summary>
    public static int size;

    /// <summary>
    /// The total number of spots on the game board.
    /// </summary>
    public static int numberOfSpots;

    /// <summary>
    /// The value representing an empty spot on the game board.
    /// </summary>
    public static int emptySpot = 0;

    /// <summary>
    /// The lowest possible score in the game.
    /// </summary>
    public static int lowestScore = 0;

    /// <summary>
    /// The minimum tile value in the game.
    /// </summary>
    public static int minTile = 2;

    /// <summary>
    /// The maximum tile value in the game.
    /// </summary>
    public static int maxTile = 2048;

    /// <summary>
    /// The minimum size of the game board.
    /// </summary>
    public static int minSize = 4;

    /// <summary>
    /// The maximum size of the game board.
    /// </summary>
    public static int maxSize = 7;

    /// <summary>
    /// The string representing the start of a row when printing the game board.
    /// </summary>
    public static string startOfRow = "|  ";

    /// <summary>
    /// The string representing the middle and end of a row when printing the game board.
    /// </summary>
    public static string midEndOfRow = "  |  ";

    /// <summary>
    /// The menu instructions for the game.
    /// </summary>
    public static string menu ="\n\nPress UP ARROW to swipe up\n" +
                                   "Press RIGHT ARROW to swipe right\n" +
                                   "Press DOWN ARROW to swipe down\n" +
                                   "Press LEFT ARROW to swipe left\n\n" +
                                   "Press R to restart the game\n" +
                                   "Press ESC to exit\n";
}
