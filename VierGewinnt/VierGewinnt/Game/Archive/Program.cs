/*namespace VierGewinnt
{
    class Spiel
    {
        public char[,] board = new char[6, 7];
        bool gameOver = false;
        bool playerWin = false;
        char inputSymbol;

        int move;

        static void Main(string[] args)
        {
            Spiel spiel = new Spiel();
            spiel.GameLoop();
        }

        //x is computer o is player
        void GameLoop()
        {
            //fill with placeholders
            for (int k = 0; k < board.GetLength(1); k++)
            {
                for (int p = 0; p < board.GetLength(0); p++)
                {
                    board[p, k] = '?';
                }
            }

            //game loop
            int i = 1;
            while (gameOver == false)
            {
                printBoard(board);


                if (i % 2 == 0)
                {
                    inputSymbol = 'x';
                    move = playerInput(board);

                    
                }
                else
                {
                    inputSymbol = 'o';
                    move = playerInput(board);
                }

                board[findLowest(move), move] = inputSymbol;

                i++;

                Console.Clear();

                CheckWin(board, 'o');
                CheckWin(board, 'x');
            }
        }

        //get player input
        int playerInput(char[,] board)
        {
            int move = 0;

            Console.Write("Player 1 : Column: ");
            move = int.Parse(Console.ReadLine());

            return move - 1;
        }

        //get second player input
        int player2Input(char[,] board)
        {
            int move = 0;

            Console.Write("Player 2 : Column: ");
            move = int.Parse(Console.ReadLine());

            return move - 1;
        }

        //find the row of the move
        int findLowest(int column)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (board[i, column] == '?')
                {
                    return i;
                }
            }

            return 8;
        }

        //gameover?
        void CheckWin(char[,] board, char Player)
        {
            //horizontal no
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7 - 3; j++)
                {
                    if (board[i, j] == Player && board[i, j + 1] == Player && board[i, j + 2] == Player && board[i, j + 3] == Player)
                    {
                        playerWin = Player == 'o' ? true : false;
                        GameOver();
                    }
                }
            }

            //vertical yes
            for (int i = 0; i < 6 - 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (board[i, j] == Player && board[i + 1, j] == Player && board[i + 2, j] == Player && board[i + 3, j] == Player)
                    {
                        playerWin = Player == 'o' ? true : false;
                        GameOver();
                    }
                }
            }

            //upward sloped diagonal no
            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 7 - 3; j++)
                {
                    if (board[i, j] == Player && board[i - 1, j + 1] == Player && board[i - 2, j + 2] == Player && board[i - 3, j + 3] == Player)
                    {
                        playerWin = Player == 'o' ? true : false;
                        GameOver();
                    }
                }
            }

            //downward sloped diagonal yes
            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 7; j++)
                {
                    if (board[i, j] != '?')
                    {
                        if (board[i, j] == Player && board[i - 1, j - 1] == Player && board[i - 2, j - 2] == Player && board[i - 3, j - 3] == Player)
                        {
                            playerWin = Player == 'o' ? true : false;
                            GameOver();
                        }
                    }
                }
            }
        }

        //printboard
        void printBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int p = 0; p < board.GetLength(1); p++)
                {
                    Console.Write(board[i, p]);
                }
                Console.WriteLine();
            }
        }

        void GameOver()
        {
            gameOver = true;
            Console.Clear();
            if (playerWin == true)
                Console.Write("Player 1 wins!");
            else
                Console.Write("Player 2 wins!");
        }
    }
}*/