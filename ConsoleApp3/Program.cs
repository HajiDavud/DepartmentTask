using ConsoleApp3.Models;
using ConsoleApp3.Repositery;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentService dc = new DepartmentService();

            Department newDep = new Department();
            newDep.id = 1;
            newDep.name = "IT";
            newDep.employeeCount = 10;

            Department newDep2 = new Department();
            newDep2.id = 2;
            newDep2.name = "Marketing";
            newDep2.employeeCount = 5;

            Department newDep3 = new Department();
            newDep2.id = 3;
            newDep2.name = "HR";
            newDep2.employeeCount = 3;

            dc.Create(newDep);
            dc.Create(newDep2);
            dc.Create(newDep3);
            dc.Delete(newDep3.id);
            foreach(var i in dc.Read())
            {
                Console.WriteLine(i.name);
            }

            Console.WriteLine(dc.Find(1).name);


            //dc.Create();

        }
    }
}
