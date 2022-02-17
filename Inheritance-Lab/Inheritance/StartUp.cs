using System;

namespace Inheritance
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var person = new Person("Pesho");
            var student = new Student("Bubata", "7 SOU");
            var employee = new Employee("John", "Kaiba Corp");

            person.Sleep();
            student.Sleep();
            employee.Sleep();

            student.Read();
        }
    }
}
