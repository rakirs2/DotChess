namespace DotChess;

internal class Console
{
    private const string _endGame = "quit";


    private readonly HashSet<string> _interfacesSupported = new() { "uci" };
    private HashSet<string> _modes = new() { "debug" };
    private HashSet<string> _state = new() { "isready" };

    public Console()
    {
        System.Console.WriteLine("Welcome To DotChess");
        var continueProgram = true;
        while (continueProgram)
        {
            var input = System.Console.ReadLine()?.ToLower();
            if (input == null || input == _endGame) continueProgram = false;

            if (input != null && _interfacesSupported.Contains(input))
            {
            }
        }
    }
}