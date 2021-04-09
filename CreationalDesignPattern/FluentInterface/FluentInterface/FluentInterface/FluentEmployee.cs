using System;

namespace FluentInterface
{
    public class FluentEmployee
    {
        private Employee employee = new Employee();
        public FluentEmployee NameOfTheEmployee(string FullName)
        {
            employee.FullName = FullName;
            Console.WriteLine(employee.FullName);
            return this;
        }
        public FluentEmployee Born(string DateOfBirth)
        {
            employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            Console.WriteLine(DateOfBirth);
            return this;
        }
        public FluentEmployee WorkingOn(string Department)
        {
            employee.Department = Department;
            Console.WriteLine(Department);
            return this;
        }
        public FluentEmployee StaysAt(string Address)
        {
            employee.Address = Address;
            Console.WriteLine(employee.Address);
            return this;
        }
    }
}
