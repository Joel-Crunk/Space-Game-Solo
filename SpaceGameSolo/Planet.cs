namespace SpaceGameSolo
{
    internal class Planet
    {
        public int Distance;
        public string Name;
        public int Ecconomy;

        public Planet()
        {
            System.Console.WriteLine("You are at Planet");
            new GameEng();
        }
    }
}