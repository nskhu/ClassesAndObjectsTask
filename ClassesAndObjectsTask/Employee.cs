using System;

namespace ClassesAndObjectsTask
{
    public class Employee
    {
        private string surname;
        private int age;

        public Employee()
        {

        }

        public Employee(string surname, int age)
        {
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname), $"{nameof(surname)} can not be null");
            this.age = age;
        }

        public void SetSurname(string surname) => this.surname = surname;

        public override string ToString()
        {
            return $"Surname: {this.surname}, Age: {age}";
        }

        private string GetAge()
        {
            return age.ToString();
        }
    }
}
