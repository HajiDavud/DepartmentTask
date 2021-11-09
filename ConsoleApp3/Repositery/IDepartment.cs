using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Repositery
{
    public interface IDepartment
    {
        Department Create(Department employee);
        Department Update(int id, Department employee);
        bool Delete(int id);
        Department[] Read();
        Department Find(int id);
    }
}
