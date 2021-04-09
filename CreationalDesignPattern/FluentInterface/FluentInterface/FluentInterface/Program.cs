using System;

namespace FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            FluentEmployee emp = new FluentEmployee();
            emp.NameOfTheEmployee("Mr A")
                    .Born("25/10/1995")
                    .WorkingOn("SE")
                    .StaysAt("Dhaka Bangladesh");


            Console.Read();
        }
    }
}
