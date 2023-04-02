using System;

namespace EmployeeRegistry
{
    partial class Program
    {
        static void EditEmployee()
        {
            Console.WriteLine("\nEdit Employee");

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            // Знаходимо працівника за ID
            Employee employeeToEdit = employees.Find(e => e.Id == id);

            // Якщо працівника не знайдено, повертаємося назад
            if (employeeToEdit == null)
            {
                Console.WriteLine("Працiвника з таким ID не знайдено.");
                return;
            }
            else
            {
                Console.WriteLine("Поточнi данi працiвника:");
                Console.WriteLine("-------------------------");
                Message(id);
                Console.WriteLine("\nЯкий параметр потрiбно змiнити?");
                Console.WriteLine("1. Прiзвище");
                Console.WriteLine("2. Iм'я");
                Console.WriteLine("3. По-батьковi");
                Console.WriteLine("4. Дата народження");
                Console.WriteLine("5. Посада");
                Console.WriteLine("6. Вiддiл");
                Console.WriteLine("7. Номер кiмнати");
                Console.WriteLine("8. Службовий телефон");
                Console.WriteLine("9. Службовий e-mail");
                Console.WriteLine("10. Мiсячний оклад");
                Console.WriteLine("11. Дата прийняття на роботу");
                Console.WriteLine("12. Примiтка");

                Console.WriteLine("Виберіть параметр працівника який потрібно змінити:");
                int EditChoice = int.Parse(Console.ReadLine());
                Edit(EditChoice);
            }
            
        }
        static void Edit(int EditChoise)
        {
            Employee employee = new Employee();
            switch (EditChoise)
            {
                case 1:
                    Console.Write("Введіть нове прізвище: ");
                    employee.LastName = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Введіть нове ім'я: ");
                    employee.FirstName = Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Введіть нове по-батькові: ");
                    employee.MiddleName = Console.ReadLine();
                    break;
                case 4:
                    Console.Write("Введіть нову Дату народження: ");
                    employee.DateOfBirth = Console.ReadLine();
                    break;
                case 5:
                    Console.Write("Введіть нову Посаду: ");
                    employee.Position = Console.ReadLine();
                    break;
                case 6:
                    Console.Write("Введіть новий Вiдділ: ");
                    employee.Department = Console.ReadLine();
                    break;
                case 7:
                    Console.Write("Введіть новий Номер кiмнати: ");
                    employee.RoomNumber = Console.ReadLine();
                    break;
                case 8:
                    Console.Write("Введіть новий службовий телефон: ");
                    employee.Phone = Console.ReadLine();
                    break;
                case 9:
                    Console.Write("Введіть новий службовий e-mail: ");
                    employee.Email = Console.ReadLine();
                    break;
                case 10:
                    Console.Write("Введіть новий мiсячний оклад: ");
                    employee.Salary = double.Parse(Console.ReadLine());
                    break;
                case 11:
                    Console.Write("Введіть нову дату прийняття на роботу: ");
                    employee.HireDate = Console.ReadLine();
                    break;
                case 12:
                    Console.Write("Введіть новi примiтки: ");
                    employee.Notes = Console.ReadLine();
                    break;
            }
        }
    }
}