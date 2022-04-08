using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;

namespace VierGewinntWPF
{
    internal class Gamelogic
    {
        public Brush PlayerColor;
        public Brush nextColor;

        //find the row of the move
        public static int FindLowest(int column, Ellipse[,] circles)
        {
            for (int i = circles.GetLength(0) - 1; i >= 0; i--)
            {
                if (circles[i, column].Fill == Brushes.Transparent)
                    return i;
            }

            return 0;
        }

        public Brush PlayerTurn(int i, Brush color1, Brush color2)
        {
            if (i % 2 == 0) {
                PlayerColor = color2;
                nextColor = color1;
            }
            else { 
                PlayerColor = color1;
                nextColor = color2;
            }

            return PlayerColor;
        }

        //gameover?
        public static bool CheckWin(Ellipse[,] circles, Brush Color, int X, int Y)
        {
            int tempY = Y;
            int tempX = X;

            //horizontal 
            while (tempX > 0 && circles[tempY, tempX - 1].Fill == Color) { tempX--; }

            if (tempX < circles.GetLength(1) - 3)
            {
                if (circles[tempY, tempX].Fill == Color && circles[tempY, tempX + 1].Fill == Color && circles[tempY, tempX + 2].Fill == Color && circles[tempY, tempX + 3].Fill == Color)
                {
                    return true;
                }
            }

            //vertical 
            if (Y < circles.GetLength(0) - 3)
            {
                if (circles[Y, X].Fill == Color && circles[Y + 1, X].Fill == Color && circles[Y + 2, X].Fill == Color && circles[Y + 3, X].Fill == Color)
                {
                    return true;
                }
            }

            //upward sloped diagonal 
            tempY = Y;
            tempX = X;
            while (tempY < 5 && tempX > 0 && circles[tempY + 1, tempX - 1].Fill == Color) { tempX--; tempY++; }
            
            if (tempY > circles.GetLength(0) - 4 && tempX < circles.GetLength(1) - 3)
            {
                if (circles[tempY, tempX].Fill == Color && circles[tempY - 1, tempX + 1].Fill == Color && circles[tempY - 2, tempX + 2].Fill == Color && circles[tempY - 3, tempX + 3].Fill == Color)
                {
                    return true;
                }
            }

            //downward sloped diagonal
            tempY = Y;
            tempX = X;
            while (tempY > 0 && tempX > 0 && tempY != 0 && tempY != 5 && circles[tempY - 1, tempX - 1].Fill == Color) { tempX--; tempY--; }

            if (tempY < circles.GetLength(0) - 3 && tempX < circles.GetLength(1) - 3)
            {
                if (circles[tempY, tempX].Fill == Color && circles[tempY + 1, tempX + 1].Fill == Color && circles[tempY + 2, tempX + 2].Fill == Color && circles[tempY + 3, tempX + 3].Fill == Color)
                {
                    return true;
                }
            }

            return false;
        }
    }
}