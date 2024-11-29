using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Fragen und Antworten
        var quiz = new List<Question>
        {
            new Question("Wie viele Planeten gibt es in unserem Sonnensystem?", "8"),
            new Question("Wer schrieb 'Faust'?", "Goethe"),
            new Question("Welche Farbe hat die Sonne?", "Gelb"),
            new Question("Wie viele Sekunden hat eine Minute?", "60"),
            new Question("Welche Programmiersprache wird hier genutzt?", "C#")
        };

        int score = 0; // Punktestand
        Console.WriteLine("Willkommen zum Quiz-Spiel!");
        Console.WriteLine("============================\n");

        for (int i = 0; i < quiz.Count; i++)
        {
            Console.WriteLine($"Frage {i + 1}: {quiz[i].Text}");
            Console.Write("Deine Antwort: ");
            string userAnswer = Console.ReadLine()?.Trim();

            if (quiz[i].CheckAnswer(userAnswer))
            {
                Console.WriteLine("Richtig! 👏");
                score++;
            }
            else
            {
                Console.WriteLine($"Falsch. Die richtige Antwort war: {quiz[i].Answer}");
            }

            Console.WriteLine();
        }

        // Ergebnis anzeigen
        Console.WriteLine("============================");
        Console.WriteLine($"Quiz beendet! Dein Punktestand: {score} von {quiz.Count}");
        Console.WriteLine("============================");
    }
}

class Question
{
    public string Text { get; set; }
    public string Answer { get; set; }

    public Question(string text, string answer)
    {
        Text = text;
        Answer = answer;
    }

    public bool CheckAnswer(string userAnswer)
    {
        return string.Equals(userAnswer, Answer, StringComparison.OrdinalIgnoreCase);
    }
}
