using Microsoft.VisualBasic;

namespace oop_assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HiringDate hireDate = new HiringDate(15, 7, 2021);
            //Employee emp = new Employee(1, "John Doe", SecurityLevel.Developer, 75000m, hireDate, Gender.M);

            //Console.WriteLine(emp);



            HiringDate hireDate1 = new HiringDate(10, 5, 2020);
            HiringDate hireDate2 = new HiringDate(3, 9, 2021);
            HiringDate hireDate3 = new HiringDate(15, 6, 2019);

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "DBA Employee", SecurityLevel.DBA, 85000m, hireDate1, Gender.M);
            EmpArr[1] = new Employee(2, "Guest Employee", SecurityLevel.Guest, 50000m, hireDate2, Gender.F);
            EmpArr[2] = new Employee(3, "Security Officer", SecurityLevel.Developer, 100000m, hireDate3, Gender.M);

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
        }
    }
}