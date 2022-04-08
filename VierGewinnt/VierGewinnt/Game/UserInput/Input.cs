using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt
{
    internal class Input
    {
        public string Name;
        public char inputSymbol;

        public int boardHeight;
        public int boardWidth;        
        
        public int PlayerInput(string playerID)
        {
            Console.Write("Player " + playerID + "'s Move: ");
            int move = int.Parse(Console.ReadLine());

            return move - 1;
        }

        public void playerInfo()
        {
            Console.Write("Player username: ");
            Name = Console.ReadLine();

            Console.Write("Preffered symbol: ");
            inputSymbol = Convert.ToChar(Console.ReadLine());

            Console.Clear();
        }

        public void boardSettings()
        {
            bool validHeight = false;
            while (validHeight == false)
            {
                Console.Write("Board Height (Min: 5, Max: 8): ");
                boardHeight = Convert.ToInt32(Console.ReadLine());
                if (boardHeight > 4 && boardHeight < 9)
                    validHeight = true;
                else
                    Console.WriteLine("Please enter a valid input...");
            }

            bool validWidth = false;
            while (validWidth == false)
            {
                Console.Write("Board Width (Min: 6, Max: 9): ");
                boardWidth = Convert.ToInt32(Console.ReadLine());
                if (boardWidth > 5 && boardWidth < 10)
                    validWidth = true;
                else
                    Console.WriteLine("Please enter a valid input...");
            }
        }
    }
}