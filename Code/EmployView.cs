using System;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeRegistry
{
    partial class Program
    {
        static void ViewEmployee()
        {
            Console.WriteLine("\nView Employee");

            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(e => e.Id == id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }
            else
            {
                Message(id);
            }
        }
        static void Message(int id)
        {
            Employee employee = employees.Find(e => e.Id == id);

            Console.WriteLine($"\nID: {employee.Id}");
            Console.WriteLine($"Last Name: {employee.LastName}");
            Console.WriteLine($"First Name: {employee.FirstName}");
            Console.WriteLine($"Middle Name: {employee.MiddleName}");
            Console.WriteLine($"Date of Dirth: {employee.DateOfBirth}");
            Console.WriteLine($"POsition: {employee.Position}");
            Console.WriteLine($"Departament: {employee.Department}");
            Console.WriteLine($"Room Number: {employee.RoomNumber}");
            Console.WriteLine($"Phone: {employee.Phone}");
            Console.WriteLine($"Email: {employee.Email}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Hire Date: {employee.HireDate}");
            Console.WriteLine($"Notes: {employee.Notes}\n");
        }
    }
}