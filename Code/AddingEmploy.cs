using System;
using System.Collections.Generic;

namespace EmployeeRegistry
{
    //Додавання та заповнення анкет Працівників 
    /*В файлі проекту "AddingEmploy.cs" створити метод для створення анкети працівників, які мають заповнюватись та зберігатись
    (звернення до методу бажано зробити за допомогою конструктора)*/
    partial class Program
    {
        /* class AddEmploy
         {
             struct AddingEmploy
             {
                 public string ID;
                 public string fname;
                 public string name;
                 public string sname;
                 public string dateborn;
                 public string position;
                 public string department;
                 public int roomnumber;
                 public int phone;
                 public string email;
                 public int salary;
                 public string DateStWork;
                 public string notes;

             public AddingEmploy(string ID, string fname, string name, string sname, string dateborn,string position, 
                 string department, int roomnumber, int phone, string email, int salary, string DateStWork, string notes)
                 {
                     this.ID = ID;
                     this.fname = fname;
                     this.name = name;
                     this.sname = sname;
                     this.dateborn = dateborn;
                     this.position = position;
                     this.department = department;
                     this.roomnumber = roomnumber;
                     this.phone = phone;
                     this.email = email;
                     this.salary = salary;
                     this.DateStWork = DateStWork;
                     this.notes = notes;
                 }
             static public void Adding()
                 {
                     List<AddingEmploy> employees = new List<AddingEmploy>();

                     string id, fn, nm, sn, db, pos, dep, em, dsw, nt;
                     int rnum, ph, sal;
                     Console.Write("Enter the employee ID: ");
                     id = Console.ReadLine();
                     Console.Write("\nEnter the employee firstname: ");
                     fn= Console.ReadLine();
                     Console.Write("\nEnter the employee name: ");
                     nm= Console.ReadLine();
                     Console.Write("\nEnter the employee surname : ");
                     sn= Console.ReadLine();
                     Console.Write("\nEnter the employee date of born (in format 00.00.00): ");
                     db= Console.ReadLine();
                     Console.Write("\nEnter the employee work position: ");
                     pos= Console.ReadLine();
                     Console.Write("\nEnter the employee work department: ");
                     dep= Console.ReadLine();
                     Console.Write("\nEnter the employee number of room: ");
                     rnum= Convert.ToInt32(Console.ReadLine());
                     Console.Write("\nEnter the employee phone number: ");
                     ph= Convert.ToInt32(Console.ReadLine());
                     Console.Write("\nEnter the employee email adress: ");
                     em= Console.ReadLine();
                     Console.Write("\nEnter the employee salary: ");
                     sal= Convert.ToInt32(Console.ReadLine());
                     Console.Write("\nEnter the employee date of employment: ");
                     dsw= Console.ReadLine();
                     Console.Write("\nEnter nots about the employee: ");
                     nt= Console.ReadLine();  

                     AddingEmploy person = new AddingEmploy(id, fn, nm, sn, db, pos, dep, rnum, ph, em, sal, dsw, nt);


                 }
             }  
         }*/
        class Employee
        {
            public int Id { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string DateOfBirth { get; set; }
            public string Position { get; set; }
            public string Department { get; set; }
            public string RoomNumber { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public double Salary { get; set; }
            public string HireDate { get; set; }
            public string Notes { get; set; }
        }
        static void AddEmployee()
        {
            Console.WriteLine("\nAdd Employee");

            Employee employee = new Employee();

            Console.Write("(ID-працiвника) ID: ");
            employee.Id = int.Parse(Console.ReadLine());

            Console.Write("(Прiзвище) Last Name: ");
            employee.LastName = Console.ReadLine();

            Console.Write("(Iм'я) First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("(По-Батьковi) Middle Name: ");
            employee.MiddleName = Console.ReadLine();

            Console.Write("(Дата народження) Date of Birth (dd/MM/YYYY): ");
            employee.DateOfBirth = Console.ReadLine();

            Console.Write("(Посада) Position: ");
            employee.Position = Console.ReadLine();

            Console.Write("(Вiддiл) Department: ");
            employee.Department = Console.ReadLine();

            Console.Write("(Номер кiмнати) Room Number: ");
            employee.RoomNumber = Console.ReadLine();

            Console.Write("(Службовий телефон) Phone: ");
            employee.Phone = Console.ReadLine();

            Console.Write("(Службовий e-mail) Email: ");
            employee.Email = Console.ReadLine();

            Console.Write("(Мiсячний оклад) Salary: ");
            employee.Salary = double.Parse(Console.ReadLine());

            Console.Write("(Дата прийняття на роботу) Hire Date (dd/MM/YYYY): ");
            employee.HireDate = Console.ReadLine();

            Console.Write("(Примiтка) Notes: ");
            employee.Notes = Console.ReadLine();

            employees.Add(employee);

            Console.WriteLine("Працiвника додано успiшно!\n  ");
        }
    }
}