using Microsoft.VisualBasic;

namespace oop_assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HiringDate hireDate = new HiringDate(15, 7, 2021);
            Employee emp = new Employee(1, "John Doe", "Developer", 75000m, hireDate, 'M');

            Console.WriteLine(emp);
        }
    }
}