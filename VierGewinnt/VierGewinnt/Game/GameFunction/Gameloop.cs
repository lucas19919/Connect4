using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt
{
    internal class Gameloop
    {
        public List<bool> wins = new List<bool>();

        char inputSymbol;
        int move;
        string playerID;

        Input input = new Input();
        Gamelogic gamelogic = new Gamelogic();
        Output Output = new Output();

        Input playerInfo1 = new Input();
        Input playerInfo2 = new Input();
        Input boardSettings = new Input();

        public void GameLoop()
        {
            playerInfo1.playerInfo();
            playerInfo2.playerInfo();

            //string lastFile = File.ReadLines(@"C:\Users\Praktikant\source\repos\VierGewinnt\VierGewinnt\Settings.txt").Last();
            //if (lastFile.Contains(":"))
            //    boardSettings.boardSettings();
            //else
            //    board = gamelogic.getLastSave(lastFile);

            //record data to txt
            //string file = @"C:\Users\Praktikant\source\repos\VierGewinnt\VierGewinnt\Settings.txt";
            //string players = "\nPlayers: " + playerInfo1.Name + ", " + playerInfo2.Name;
            //File.AppendAllText(file, players);

            char[,] board = new char[boardSettings.boardHeight, boardSettings.boardWidth];

            //fill with placeholders
            for (int k = 0; k < board.GetLength(1); k++)
                for (int p = 0; p < board.GetLength(0); p++)
                    board[p, k] = ' ';

            //game loop
            int i = 1;
            while (true)
            {
                Output.PrintBoard(board);

                if (i % 2 == 0)
                {
                    playerID = playerInfo2.Name;
                    inputSymbol = playerInfo2.inputSymbol;
                    move = input.PlayerInput(playerID);
                }
                else
                {
                    playerID = playerInfo1.Name;
                    inputSymbol = playerInfo1.inputSymbol;
                    move = input.PlayerInput(playerID);
                }

                int lowest = gamelogic.FindLowest(move, board);
                board[lowest, move] = inputSymbol;
                Output.BoardAnimation(lowest, move, board, inputSymbol);

                i++;

                Console.Clear();

                if (i > 7)
                    gamelogic.CheckWin(board, inputSymbol, move, lowest, playerID);
            }
        }
    }
}