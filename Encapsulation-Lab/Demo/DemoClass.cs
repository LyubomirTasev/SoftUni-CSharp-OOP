using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class DemoClass
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public DemoClass(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public DemoClass(string firstName, string lastName, int age, decimal salary)
            : this(firstName, lastName, age)
        {
            Salary = salary;
        }

        public string FirstName
        {
            get => firstName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!", "FirstName");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!", "LastName");
                }

                lastName = value;
            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age cannot be zero or a negative integer!");
                }

                age = value;
            }
        }

        public decimal Salary
        {
            get => salary;
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentOutOfRangeException("Salary", "Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age >= 30)
            {
                Salary += Salary * percentage / 100;
            }
            else
            {
                Salary += Salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old with salary {Salary:f2} leva.";
        }
    }
}
