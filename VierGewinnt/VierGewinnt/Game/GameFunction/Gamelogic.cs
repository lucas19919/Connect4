using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VierGewinnt
{ 
    internal class Gamelogic
    {        
        //find the row of the move
        public int FindLowest(int column, char[,] board)
        {
            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                if (board[i, column] == ' ')
                    return i;
            }

            return -1;
        }

        //gameover?
        public void CheckWin(char[,] board, char Player, int X, int Y, string playerID)
        {
            Gameloop gameloop = new Gameloop();

            int tempY = Y;
            int tempX = X;

            //horizontal 
            while (board[tempY, tempX] == Player && tempX > 0)
            {
                tempX--;
            }

            if (tempX < 3)
            {
                if (board[tempY, tempX] == Player && board[tempY, tempX + 1] == Player && board[tempY, tempX + 2] == Player && board[tempY, tempX + 3] == Player)
                {
                    GameOver(playerID);
                }
            }

            //vertical 
            if (Y < 3)
            {
                if (board[Y, X] == Player && board[Y + 1, X] == Player && board[Y + 2, X] == Player && board[Y + 3, X] == Player)
                {
                    GameOver(playerID);
                }
            }

            //upward sloped diagonal 
            tempY = Y;
            tempX = X;
            while (board[tempY, tempX] == Player && tempY < 5 && tempX > 0)
            {
                tempY++;
                tempX--;
            }

            if (tempY > 2 && tempX < 4)
            {
                if (board[tempY, tempX] == Player && board[tempY - 1, tempX + 1] == Player && board[tempY - 2, tempX + 2] == Player && board[tempY - 3, tempX + 3] == Player)
                {
                    GameOver(playerID);
                }
            }

            //downward sloped diagonal 
            tempY = Y;
            tempX = X;
            while (board[tempY, tempX] == Player && tempY > 0 && tempX > 0)
            {
                tempY--;
                tempX--;
            }

            if (tempY < 3 && tempX < 4)
            {
                if (board[tempY, tempX] == Player && board[tempY + 1, tempX + 1] == Player && board[tempY + 2, tempX + 2] == Player && board[tempY + 3, tempX + 3] == Player)
                {
                    GameOver(playerID);
                }
            }
        }

        //if gameover end game and reinitalize
        private void GameOver(string PlayerID)
        {
            Gameloop gameloop = new Gameloop();
            Input input = new Input();

            //string file = @"C:\Users\Praktikant\source\repos\VierGewinnt\VierGewinnt\Settings.txt";
            //string winner = "\nWinner: " + PlayerID;
            //File.AppendAllText(file, winner);

            Console.Clear();
            Console.Write("Player {0} wins!", PlayerID); 

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            Console.Clear();
            Call.Main();
        }

        /*public char[,] getLastSave(string saveFile)
        {
            saveFile.ToCharArray();
            char[,] board = new char[saveFile[0], saveFile[1]];

            int c = 2;
            for (int i = 0; i < saveFile[0]; i++)
            {
                for (int b = 0; b < saveFile[1]; b++)
                {
                    board[i, b] = saveFile[c];
                    c++;
                }
            }

            return board;
        }*/
    }
}