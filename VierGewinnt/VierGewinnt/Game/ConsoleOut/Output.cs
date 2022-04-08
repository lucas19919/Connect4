using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VierGewinnt
{
    internal class Output
    {
        //printboard
        public void PrintBoard(char[,] board)
        {
            Console.Clear();
            
            for (int p = 0; p < board.GetLength(1); p++)
            {
                Console.Write("+---");
            }
            Console.Write("+");
            Console.WriteLine();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("|");
                for (int p = 0; p < board.GetLength(1); p++)
                {
                    Console.Write(" " + board[i, p] + " |");
                }
                Console.WriteLine();
                for (int p = 0; p < board.GetLength(1); p++)
                {
                    Console.Write("+---");
                }
                Console.Write("+");

                Console.WriteLine();
            }
        }

        public void BoardAnimation(int Y, int X, char[,] board, char inputSymbol)
        {
            for (int c = 0; c < Y; c++)
            {
                Console.Clear();
                board[Y, X] = ' ';
                board[c, X] = inputSymbol;

                for (int p = 0; p < board.GetLength(1); p++)
                {
                    Console.Write("+---");
                }
                Console.Write("+");
                Console.WriteLine();
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int p = 0; p < board.GetLength(1); p++)
                    {
                        Console.Write(" " + board[i, p] + " |");
                    }
                    Console.WriteLine();
                    for (int p = 0; p < board.GetLength(1); p++)
                    {
                        Console.Write("+---");
                    }
                    Console.Write("+");

                    Console.WriteLine();
                }
                board[c, X] = ' ';
                Thread.Sleep(100);
                Console.Clear();
            }

        board[Y, X] = inputSymbol;
        }
    }
}