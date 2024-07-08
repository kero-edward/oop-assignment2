using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment2
{
    public enum Gender
    {
        M,
        F 
    }

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }


    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hireDate;
        private Gender gender;


        public Employee(int _id, string _name, SecurityLevel _securityLevel, decimal _salary, HiringDate _hireDate, Gender _gender)
        {
            this.ID = _id;
            this.Name = _name;
            this.SecurityLevel = _securityLevel;
            this.Salary = _salary;
            this.HireDate = _hireDate;
            this.Gender = _gender;
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

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                if (!Enum.IsDefined(typeof(SecurityLevel), value))
                    throw new ArgumentException("Invalid Security Level.");
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

        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (!Enum.IsDefined(typeof(Gender), value))
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                gender = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {String.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}, Hire Date: {HireDate}, Gender: {Gender}";
        }
    }
}
