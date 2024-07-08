using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment2
{
    internal class Employee
    {
        private int id;
        private string name;
        private string securityLevel;
        private decimal salary;
        private HiringDate hireDate;
        private char gender;


        public Employee(int _id, string _name, string _securityLevel, decimal _salary, HiringDate _hireDate, char _gender)
        {
            this.id = _id;
            this.name = _name;
            this.securityLevel = _securityLevel;
            this.salary = _salary;
            this.hireDate = _hireDate;
            this.gender = _gender;
        }

        public int ID
        {
            get { return id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID must be positive.");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public string SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Security Level cannot be empty.");
                securityLevel = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }

        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value != 'M' && value != 'F')
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                gender = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Gender: {Gender}";
        }
    }
}
