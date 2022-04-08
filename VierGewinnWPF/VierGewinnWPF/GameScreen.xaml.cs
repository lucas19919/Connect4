using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Threading;

namespace VierGewinntWPF
{
    public partial class GameScreen
    {
        Gamelogic gamelogic = new();
        ComputerPlayer player = new();

        public Ellipse[,] cirArray;
        public Button[] btnArray;
        public Brush[] colorArray = { Brushes.Red, Brushes.Green, Brushes.Blue, Brushes.Yellow };

        int YSize;
        int XSize;
        public bool gameover;
        string CurrentPlayer;

        public Brush colorP1;
        public Brush colorP2;
        public Brush buttonB = new SolidColorBrush(Color.FromRgb(61, 61, 61));

        public int I = 1;
        List<String> matches = new();

        public GameScreen()
        {
            InitializeComponent();
            Format();
            Rectangles();
            Buttons();
        }

        public void Format()
        {
            YSize = int.Parse(Board_Height.Text);
            XSize = int.Parse(Board_Width.Text);

            Canvas.Width = (XSize * 50) + 1 + XSize;
            Canvas.Height = (YSize * 50) + 1 + YSize;
            Application.Current.MainWindow.Width = (XSize * 50) + 201 + XSize;
            Application.Current.MainWindow.Height = (YSize * 50) + 178 + YSize;
            maingrid.Width = (XSize * 50) + 200;
            maingrid.Height = (YSize * 50) + 177;
            Grid.SetZIndex(GameStatus, 1);
            PlayerTurn.Fill = colorP1;
        }

        public void Rectangles()
        {
            cirArray = new Ellipse[YSize, XSize];
            int height = 1;
            int right = 1;
            for (int y = 0; y < cirArray.GetLength(0); y++)
            {
                for (int x = 0; x < cirArray.GetLength(1); x++)
                {
                    cirArray[y, x] = new Ellipse
                    {
                        Height = 50,
                        Width = 50,
                        Margin = new Thickness(right, height, 0, 0),
                        Fill = Brushes.Transparent,
                        Stroke = Brushes.Transparent,
                        HorizontalAlignment = HorizontalAlignment.Left
                    };

                    Canvas.Children.Add(cirArray[y, x]);
                    right += 51;
                }
                height += 51;
                right = 1;
            }
        }
        public void Buttons()
        {
            btnArray = new Button[XSize];
            int right = 0;

            for (int x = 0; x < btnArray.Length; x++)
            {
                btnArray[x] = new Button
                {
                    Height = 50,
                    Width = 51,
                    Margin = new Thickness(right, 0, 0, 0),
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Tag = x,
                    Background = buttonB,
                    BorderBrush = Brushes.Transparent
                };

                btnArray[x].AddHandler(ButtonBase.ClickEvent, new RoutedEventHandler(DiscBtn_click));

                Grid.SetColumn(btnArray[x], 1);
                Grid.SetRow(btnArray[x], 3);
                maingrid.Children.Add(btnArray[x]);
                right += 51;
            }
        }

        public void AddToBoard(int? x)
        {
            int X = x.Value;
            int lowest;

            if (gameover == false)
            {
                gamelogic.PlayerTurn(I, colorP1, colorP2);
                lowest = Gamelogic.FindLowest(X, cirArray);
                if (cirArray[lowest, X].Fill == Brushes.Transparent)
                {
                    cirArray[lowest, X].Fill = gamelogic.PlayerColor;
                }
                if (I > 6)
                    gameover = Gamelogic.CheckWin(cirArray, gamelogic.PlayerColor, X, lowest);

                if (gameover == true)
                {
                    if (gamelogic.PlayerColor == colorP1)
                        CurrentPlayer = Player1Name.Text;
                    else
                        CurrentPlayer = Player2Name.Text;
                    GameStatus.Content = "Game over, winner: " + CurrentPlayer;

                    matches.Add("Winner: " + CurrentPlayer);
                }
                if (I == (XSize * YSize) + 1)
                {
                    GameStatus.Content = "Game over, draw!";
                    matches.Add("Tie");
                }
                PlayerTurn.Fill = gamelogic.nextColor;
                I++;
            }
        }

        public void ResetRct()
        {
            for (int y = 0; y < cirArray.GetLength(0); y++)
            {
                for (int x = 0; x < cirArray.GetLength(1); x++)
                {
                    cirArray[y, x].Fill = Brushes.Transparent;
                }
            }
        }

        //button click functions
        public void DiscBtn_click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            int? x = b.Tag as int?;
            AddToBoard(x);

            if (vsComputer.IsChecked == true)
            {
                int c = player.ComputerMove(cirArray, colorP1);
                AddToBoard(c);
            }
        }

        private void History_Click(object sender, RoutedEventArgs e)
        {
            History history = new();
            history.GetMatches(matches);
            history.Show();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            ResetRct();
            I = 1;
            gameover = false;
            PlayerTurn.Fill = colorP1;
            GameStatus.Content = "Connect 4";
        }

        public void BoardChange_Click(object sender, RoutedEventArgs e)
        {
            YSize = int.Parse(Board_Height.Text);
            XSize = int.Parse(Board_Width.Text);

            if (YSize <= 11 && YSize >= 6 && XSize <= 12 && XSize >= 7)
            {
                Canvas.Children.Clear();

                for (int x = 0; x < btnArray.Length; x++)
                {
                    maingrid.Children.Remove(btnArray[x]);
                }
                PlayerTurn.Fill = colorP1;

                Format();
                Rectangles();
                Buttons();
                ResetRct();
                Line.Height = maingrid.Height - 75;

                I = 1;
                GameStatus.Content = "Connect 4";
            }
            else
                GameStatus.Content = "Invalid Board: Y Max 11, Min 6, X Max 12, Min 7";
        }


        private void Player1C_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorP2 != colorArray[Player1C.SelectedIndex])
            {
                colorP1 = colorArray[Player1C.SelectedIndex];
            }
            else
                Player1C.SelectedIndex = Array.IndexOf(colorArray, colorP1);
        }

        private void Player2C_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorP1 != colorArray[Player2C.SelectedIndex])
            {
                colorP2 = colorArray[Player2C.SelectedIndex];
            }
            else
                Player2C.SelectedIndex = Array.IndexOf(colorArray, colorP2);
        }

        private void Checked(object sender, RoutedEventArgs e)
        {
            Player2Name.Text = "Computer";
            Player2Name.IsEnabled = false;
            Player2C.Foreground = Brushes.Gray;
            Player2C.SelectedIndex = 0;
            Player2C.IsEnabled = false;
            Player2C.Foreground = Brushes.Gray;
        }
        private void Unchecked(object sender, RoutedEventArgs e)
        {
            Player2Name.Text = "Player 2";
            Player2Name.Foreground= Brushes.White;
            Player2Name.IsEnabled = true;
            Player2C.Foreground = Brushes.White;
            Player2C.IsEnabled = true;
        }
    }
}