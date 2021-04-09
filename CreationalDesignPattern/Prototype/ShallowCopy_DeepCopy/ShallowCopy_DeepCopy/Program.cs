using System;

namespace ShallowCopy_DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Name = "Mr A";
            emp1.Department = "IT";
            emp1.EmpAddress = new Address() { address = "BBSR" };
            Employee emp2 = emp1.GetClone();
            emp2.Name = "Mr B";
            emp2.EmpAddress.address = "Mumbai";
            Console.WriteLine("E-1: ");
            Console.WriteLine("Name: " + emp1.Name + ", Address: " + emp1.EmpAddress.address + ", Dept: " + emp1.Department);
            Console.WriteLine("E-2: ");
            Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);
            Console.Read();
        }
    }
}
