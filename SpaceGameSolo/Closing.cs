using System;
namespace SpaceGameSolo
{
    internal class Closing
    {
        public Closing()
        {

            void CenteredString(string s)
            {
                if (s.Length <= Console.WindowWidth)
                {
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(s);
                }

                else
                {
                    throw new Exception("Oversided String");
                }
            }
            Console.WriteLine("\n\n");

            CenteredString("Good bye!");
        }
    }
}