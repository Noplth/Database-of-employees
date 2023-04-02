using System;
using System.Collections.Generic;

namespace EmployeeRegistry
{
    partial class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                // друк меню вибору
                Console.WriteLine("Виберiть номер дiї:");
                Console.WriteLine("1. - Додати Працiвника");
                Console.WriteLine("2. - Перегляд Працiвника");
                Console.WriteLine("3. - Редагування даних про працiвника");
                Console.WriteLine("4. - Видалення працiвника");
                Console.WriteLine("5. - Згенерувати Звiт");
                Console.WriteLine("6. - Вихiд");

                // отримуємо вибір користувача
                int userChoice = 0;
                bool isValidChoice = false;

                //Цикл для перевірки даних введених користувачем 
                while (!isValidChoice)
                {
                    Console.Write("Ваш вибiр: ");
                    if (int.TryParse(Console.ReadLine(), out userChoice))
                    {
                        if (userChoice >= 1 && userChoice <= 5)
                        {
                            isValidChoice = true;
                        }
                        else
                        {
                            Console.WriteLine("Не коректно введений вибiр. Спробуйте ще раз.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Не коректно введений вибiр. Спробуйте ще раз.");
                    }
                }

                // обробка вибору користувача
                switch (userChoice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployee();
                        break;
                    case 3:
                        EditEmployee();
                        break;
                    case 4:
                        // Місце звернення до функції відповідоного класу
                        break;
                    case 5:
                        // Місце звернення до функції відповідоного класу
                        break;
                    case 6:
                        //
                        break;
                    default:

                        break;
                }
            }
        }
    }
}