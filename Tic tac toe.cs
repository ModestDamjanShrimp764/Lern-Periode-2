using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            bool gameRunning = true;

            while (gameRunning)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Spieler {currentPlayer}, dein Zug. Wähle ein Feld (1-9):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int field) && field >= 1 && field <= 9)
                {
                    if (MakeMove(field))
                    {
                        if (CheckWin())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine($"Herzlichen Glückwunsch, Spieler {currentPlayer} hat gewonnen!");
                            gameRunning = false;
                        }
                        else if (CheckDraw())
                        {
                            Console.Clear();
                            DrawBoard();
                            Console.WriteLine("Unentschieden! Kein Spieler gewinnt.");
                            gameRunning = false;
                        }
                        else
                        {
                            SwitchPlayer();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Das Feld ist bereits belegt. Drücke eine beliebige Taste, um es erneut zu versuchen.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Zahl zwischen 1 und 9.");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Spiel beendet. Drücke eine beliebige Taste, um zu schließen.");
            Console.ReadKey();
        }

        static void DrawBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("---|---|---");
            Console.WriteLine(" {0} | {1} | {2} ", board[2, 0], board[2, 1], board[2, 2]);
        }

        static bool MakeMove(int field)
        {
            int row = (field - 1) / 3;
            int col = (field - 1) % 3;

            if (board[row, col] != 'X' && board[row, col] != 'O')
            {
                board[row, col] = currentPlayer;
                return true;
            }
            return false;
        }

        static void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        static bool CheckWin()
        {
            // Zeilen prüfen
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;
            }

            // Spalten prüfen
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            }

            // Diagonalen prüfen
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;
            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        static bool CheckDraw()
        {
            foreach (char field in board)
            {
                if (field != 'X' && field != 'O')
                    return false;
            }
            return true;
        }
    }
}
