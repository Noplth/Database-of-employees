using System;

namespace Database_of_employees.Code
{
    public class MainMenu
    {
        public int NumChange;
        public void Message()
        {
            Console.Write("Виберіть дію яку хочете виконати:\n1: Вибрати нового працівника\n" +
                "2: Переглянути дані працівника\n" +
                "3: Редагувати існуючуго працівника\n" +
                "4: Видалити існуючого працівника \n" +
                "5: Згенерувати звіт ");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu LetsGo = new MainMenu();
            LetsGo.Message();
        }
    }

}