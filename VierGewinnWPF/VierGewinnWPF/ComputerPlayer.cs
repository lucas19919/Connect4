using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Linq;

namespace VierGewinntWPF
{
    internal class ComputerPlayer
    {
        int[] possibleMoves;
        public int[,] board;

        public int Counter = 0;
        public int CCounter = 0;
        public int PCounter = 0;
        public int ECounter = 0;
        public int temp = 3;

        public int ComputerMove(Ellipse[,] circles, Brush Player)
        {
            board = Format(circles, Player);
            
            //format possible moves
            possibleMoves = new int[circles.GetLength(1)];
            for (int i = 0; i < possibleMoves.Length; i++)
                possibleMoves[i] = GetLowest(i, board);
            
            //evaluate every point
            for (int i = 0; i < possibleMoves.Length; i++)
                possibleMoves[i] = Evaluate(board, possibleMoves[i], i);

            //get and return the best move
            return BestMove(possibleMoves);
        }
        private static int BestMove(int[] moves)
        {
            int bestMove = Array.IndexOf(moves, moves.Max());
            return bestMove;
        }

        public int PointsCalculator(int points)
        {
            int possiblePoints = 0;
            possiblePoints += (CCounter * 1) + (PCounter * 2) + (Counter * 3);

            if (possiblePoints > points)
                points = possiblePoints;
            return points;
        }

        public int[,] Format(Ellipse[,] circles, Brush Player)
        {
            board = new int[circles.GetLength(0), circles.GetLength(1)];
            for (int i = 0; i < board.GetLength(1); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    if (circles[k, i].Fill == Brushes.Transparent)
                        board[k, i] = 0;
                    if (circles[k, i].Fill == Brushes.Red)
                        board[k, i] = 1;
                    if (circles[k, i].Fill == Player)
                        board[k, i] = 2;
                }
            }

            return board;
        }

        private static int GetLowest(int column, int[,] board)
        {
            for (int i = board.GetLength(0) - 1; i >= 0; i--)
            {
                if (board[i, column] == 0)
                    return i;
            }

            return 0;
        }


        //takes the move and evaluates the opponents responses
        private static int Evaluate(int[,] board, int y, int x)
        {
            //is the move possible
            if (board[y, x] != 0)
                return 0;
            int points 
                = 0;

            points += IsWin(board, x, y, 2);
            points += IsWin(board, x, y, 1);

            return points;
        }

        private static int IsWin(int[,] board, int x, int y, int currentCheck)
        {
            int points = 0;
            int HLength = 0;
            int VLength = 0;
            int DDownLength = 0;
            int DUpLength = 0;

            int height = board.GetLength(0);
            int width = board.GetLength(1);

            //horizontal check
            for(int i = x; i > 0 && i > x - 3; i--) //left
                if (board[y, i - 1] == currentCheck)
                    HLength++;
            for (int i = x; i < 6 && i < x + 3; i++) //right
                if (board[y, i + 1] == currentCheck)
                    HLength++;

            //vertical
            for (int i = y; i < 5 && i < y + 3; i++) 
                if (board[i + 1, x] == currentCheck)
                    VLength++;

            //diagonal check
            for (int i = x, k = y; i < width - 1 && k < height - 1 && i < x + 3 && k < y + 3; i++, k++) //down down
                if (board[k + 1, i + 1] == currentCheck)
                    DDownLength++;
            for (int i = x, k = y; i > 0 && k > 0 && i > x - 3 && k > y - 3; i--, k--) //down up
                if (board[k - 1, i - 1] == currentCheck)
                    DDownLength++;
            for (int i = x, k = y; i > 0 && k < height - 1 && i > x - 3 && k < y + 3; i--, k++) //up down
                if (board[k + 1, i - 1] == currentCheck)
                    DDownLength++;
            for (int i = x, k = y; i < width - 1 && k > 0 && i < x + 3 && k > y - 3; i++, k--) //up up
                if (board[k - 1, i + 1] == currentCheck)
                    DDownLength++;

            if (VLength == 3 | HLength == 3 | DDownLength == 3 | DUpLength == 3 && currentCheck == 1)
                points += 1500;
            if (VLength == 3 | HLength == 3 | DDownLength == 3 | DUpLength == 3 && currentCheck == 2)
                points += 1000;

            if (currentCheck == 2)
                points +=  (VLength + HLength + DDownLength + DUpLength);
            else
                points += (VLength + HLength + DDownLength + DUpLength) * 2;

            return points;
        }
    }
}