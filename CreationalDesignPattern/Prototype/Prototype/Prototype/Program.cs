using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Mr A";
            user.Department = "DEVOPS";
            User user2 = user.GetClone();
            user2.Name = "Mr B";

            Console.WriteLine("Emplpyee 1: ");
            Console.WriteLine("Name: " + user.Name + ", Department: " + user.Department);
            Console.WriteLine("Emplpyee 2: ");
            Console.WriteLine("Name: " + user2.Name + ", Department: " + user2.Department);
            Console.Read();
        }
    }
}
