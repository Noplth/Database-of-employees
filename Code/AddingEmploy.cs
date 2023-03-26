using System;
using System.Collections.Specialized;

namespace Database_of_employees.Code
{
//Додавання та заповнення анкет Працівників 
/*В файлі проекту "AddingEmploy.cs" створити метод для створення анкети працівників, які мають заповнюватись та зберігатись
(звернення до методу бажано зробити за допомогою конструктора)*/

    class AddEmploy
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
        public void Add()
            {
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

            List<AddEmploy> Employs = new List<AddEmploy>();
            Employs.Add(new AddEmploy(person));
            }
        }   
    }
}