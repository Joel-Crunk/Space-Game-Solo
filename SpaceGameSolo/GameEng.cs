using System;

namespace SpaceGameSolo
{
    internal class GameEng
    {
        public GameEng()
        {
            menu();

        }

        private void menu()
        {
            Console.WriteLine("1. Travel");
            Console.WriteLine("2. Warehouse");
            Console.WriteLine("3. EXIT");
            try
            {
                int Input = int.Parse(Console.ReadLine());

                if (Input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("You selected Travel in the menu");
                    Travel();
                }
                else if (Input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("You selected Warehouse");
                    Warehouse();
                }
                else if (Input == 3)
                {
                    new Closing();
                }
                else
                {
                    Console.WriteLine(" invalid input");
                    Rerun();
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input! Lets try again.");
                Rerun();
            }
            
        }

        private void Rerun()
        { 
            menu();
        }

        private void Warehouse()
        {
            Console.WriteLine("Warehouse!");
            new Store();
        }

        private void Travel()
        {
            Console.WriteLine(" Travel!");
            new Planet();
        }
    }
}