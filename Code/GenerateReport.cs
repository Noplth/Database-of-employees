using System;

namespace Database_of_employees.Code
{
    class GenerateReport
    {
        public void GenRepo()
        {
            Console.WriteLine("Працівники , які працюють у відділі 'Інформаційний обчислювальний центр(ІОЦ):'");
            Console.WriteLine("____________________________________________________________________________________________________________________________________\n");
            Console.WriteLine("| ID | Прізвище | По-батькові | Дата народження | Посада | Підрозділ(відділ) | Номер кімнати | Службовий телефон | Службовий email |\n\n ");
            Console.WriteLine("____________________________________________________________________________________________________________________________________\n");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("|Місячний оклад | Дата прийняття на роботу | Поле для приміток |\n");
            Console.WriteLine("_______________________________________________________________\n");
            Console.WriteLine("Працівники , які працюють на посаді 'Програміст':");
            Console.WriteLine("____________________________________________________________________________________________________________________________________\n");
            Console.WriteLine("| ID | Прізвище | По-батькові | Дата народження | Посада | Підрозділ(відділ) | Номер кімнати | Службовий телефон | Службовий email |\n\n ");
            Console.WriteLine("____________________________________________________________________________________________________________________________________\n");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("|Місячний оклад | Дата прийняття на роботу | Поле для приміток |\n");
            Console.WriteLine("_______________________________________________________________");
        }
    }
}