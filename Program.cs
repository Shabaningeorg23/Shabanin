using System;
class NumberGuessingGame
{
    static void Main()
    {
        Game game = new Game();
        game.Start();
    }
}
class Game
{
    private Random random = new Random();
    private int attempsUsed = 0;
    private int remainingAttemps = 3;
    private int number;

    public void Start()
    {
        number = random.Next(0, 10);
        Console.WriteLine("У тебя есть 3 попытки угадать число");

        while (attempsUsed < 3)
        {
            Console.Write("Введите число: ");
            int number2 = int.Parse(Console.ReadLine());
            attempsUsed++;
            remainingAttemps--;

            if (number2 < 0 || number2 > 10)
            {
                attempsUsed--;
                remainingAttemps++;
                Console.WriteLine("Недопустимое число, введи число от 0 до 10");
                Console.WriteLine("У тебя осталось {0} попыток, попробуй еще!", remainingAttemps);
            }
            else if (number == number2)
            {
                Console.WriteLine("Поздравляю, ты угадал мое число, использовав {0} попыток!", attempsUsed);
                break;
            }
            else if (attempsUsed == 3)
            {
                Console.WriteLine("А вот и не угадал! Я загадывал число {0}", number);
            }
            else
            {
                Console.WriteLine("У тебя осталось {0} попыток, попробуй еще!", remainingAttemps);
            }
        }
    }
}