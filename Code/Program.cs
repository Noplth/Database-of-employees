using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // друк меню вибору
            Console.WriteLine("Виберіть тип дії:");
            Console.WriteLine("1 - Ввід даних");
            Console.WriteLine("2 - Виведення даних");
            Console.WriteLine("3 - Редагування даних");
            Console.WriteLine("4 - Видалення даних");
            Console.WriteLine("5 - Вихід");

            // отримуємо вибір користувача
            int userChoice = 0;
            bool isValidChoice = false;

            while (!isValidChoice)
            {
                Console.Write("Ваш вибір: ");
                if (int.TryParse(Console.ReadLine(), out userChoice))
                {
                    if (userChoice >= 1 && userChoice <= 5)
                    {
                        isValidChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    }
                }
                else
                {
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                }
            }

            // обробка вибору користувача
            switch (userChoice)
            {
                case 1:
                    // функціонал для введення даних
                    break;
                case 2:
                    // функціонал для виведення даних
                    break;
                case 3:
                    // функціонал для редагування даних
                    break;
                case 4:
                    // функціонал для видалення даних
                    break;
                case 5:
                    // вихід з програми
                    return;
            }
        }
    }
}