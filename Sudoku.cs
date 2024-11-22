using System;

class Program
{
    static int[,] sudokuGrid = new int[9, 9];
    static Random random = new Random();

    static void Main()
    {
        GenerateSudoku();
        PlaySudoku();
    }

    static void GenerateSudoku()
    {
        // Initialisiere ein paar zufällige Zahlen im Sudoku (Beispielhaft)
        for (int i = 0; i < 9; i++)
        {
            int row = random.Next(0, 9);
            int col = random.Next(0, 9);
            int value = random.Next(1, 10);

            if (IsValidMove(row, col, value))
            {
                sudokuGrid[row, col] = value;
            }
        }
    }

    static void PlaySudoku()
    {
        while (true)
        {
            Console.Clear();
            PrintSudoku();

            Console.WriteLine("Geben Sie die Zeile (1-9), Spalte (1-9) und die Zahl (1-9) ein, getrennt durch Leerzeichen:");
            Console.WriteLine("Beispiel: 1 3 7 setzt eine 7 in Zeile 1, Spalte 3.");
            Console.WriteLine("Geben Sie '0 0 0' ein, um das Spiel zu beenden.");

            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length != 3 ||
                !int.TryParse(parts[0], out int row) ||
                !int.TryParse(parts[1], out int col) ||
                !int.TryParse(parts[2], out int value))
            {
                Console.WriteLine("Ungültige Eingabe. Versuchen Sie es erneut.");
                continue;
            }

            if (row == 0 && col == 0 && value == 0)
            {
                Console.WriteLine("Spiel beendet.");
                break;
            }

            row--; // Indizes anpassen
            col--;

            if (row < 0 || row >= 9 || col < 0 || col >= 9 || value < 1 || value > 9)
            {
                Console.WriteLine("Ungültige Eingabe. Zeile, Spalte und Wert müssen im Bereich 1-9 liegen.");
                continue;
            }

            if (sudokuGrid[row, col] != 0)
            {
                Console.WriteLine("Das Feld ist bereits belegt.");
                continue;
            }

            if (IsValidMove(row, col, value))
            {
                sudokuGrid[row, col] = value;
                Console.WriteLine("Zug erfolgreich!");
            }
            else
            {
                Console.WriteLine("Ungültiger Zug. Diese Zahl passt nicht in das Raster.");
            }
        }
    }

    static void PrintSudoku()
    {
        Console.WriteLine("   1 2 3   4 5 6   7 8 9");
        Console.WriteLine("  +-------+-------+-------+");

        for (int i = 0; i < 9; i++)
        {
            Console.Write($"{i + 1} |");
            for (int j = 0; j < 9; j++)
            {
                if (sudokuGrid[i, j] == 0)
                {
                    Console.Write(" .");
                }
                else
                {
                    Console.Write($" {sudokuGrid[i, j]}");
                }

                if ((j + 1) % 3 == 0) Console.Write(" |");
            }
            Console.WriteLine();
            if ((i + 1) % 3 == 0) Console.WriteLine("  +-------+-------+-------+");
        }
    }

    static bool IsValidMove(int row, int col, int value)
    {
        // Zeilen- und Spaltenprüfung
        for (int i = 0; i < 9; i++)
        {
            if (sudokuGrid[row, i] == value || sudokuGrid[i, col] == value)
            {
                return false;
            }
        }

        // 3x3-Box-Prüfung
        int startRow = (row / 3) * 3;
        int startCol = (col / 3) * 3;

        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (sudokuGrid[i, j] == value)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
