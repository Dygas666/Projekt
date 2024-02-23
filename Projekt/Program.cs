using System;

class QuizGame
{
    static void Main()
    {
        Console.WriteLine("Witaj w grze quizowej!");

        Console.Write("Podaj ilość graczy: ");
        int totalPlayers = Convert.ToInt32(Console.ReadLine());

        for (int currentPlayer = 1; currentPlayer <= totalPlayers; currentPlayer++)
        {
            Console.WriteLine($"\nGracz {currentPlayer}, twój wynik: {AskQuestion()}\n");
        }

        Console.WriteLine("\nGra zakończona. Dziękujemy za udział!");
    }

    static int AskQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4);

        switch (randomNumber)
        {
            case 1:
                Console.WriteLine("\nPytanie: Jaki jest kolor trawy?");
                return Console.ReadLine().ToLower() == "zielony" ? 1 : 0;

            case 2:
                Console.WriteLine("\nPytanie: Ile wynosi 3 * 7?");
                return Convert.ToInt32(Console.ReadLine()) == 21 ? 1 : 0;

            case 3:
                Console.WriteLine("\nPytanie: Kto jest prezydentem Polski?");
                return Console.ReadLine().ToLower() == "andrzej duda" ? 1 : 0;

            default:
                return 0;
        }
    }
}
