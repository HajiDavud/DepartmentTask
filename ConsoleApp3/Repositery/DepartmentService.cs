using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Repositery
{
    public class DepartmentService : IDepartment
    {
        private Department[] departments = new Department[0];
        public Department Create(Department newDepartment)
        {
            Array.Resize(ref departments,departments.Length+1);
            departments[departments.Length - 1] = newDepartment;
            return newDepartment;
        }

        public bool Delete(int id)
        {
            Array.FindAll(departments, e => e.id != id);
            return true;
        }

        public Department Find(int id)
        {
            Department depart = Array.Find(departments,e => e.id == id);
            return depart;
        }

        public Department[] Read()
        {
            return departments;
        }

        public Department Update(int id, Department newDep)
        {
            Department updatedDep = Array.Find(departments, e => e.id == id);
            updatedDep = newDep;
            return newDep;
        }
    }
}
