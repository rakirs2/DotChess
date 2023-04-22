namespace DotChess
{
    internal class Console
    {
        public Console()
        {
            System.Console.WriteLine("Welcome To DotChess");
            bool continueProgram = true;
            while (continueProgram)
            {
                string input = System.Console.ReadLine().ToLower();
                if (input == null || input == EndGame)
                {
                    continueProgram = false;
                }

                if (InterfacesSupported.Contains(input))
                {

                }
            } 

        }


        private HashSet<String> InterfacesSupported = new HashSet<String>() { "uci" };
        private HashSet<String> Modes = new HashSet<String>() { "debug" };
        private HashSet<String> state = new HashSet<String>() { "isready" };
        private String EndGame = "quit";
    }
}
