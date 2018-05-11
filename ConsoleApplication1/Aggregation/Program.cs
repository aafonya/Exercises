using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAssociation
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Car c = new Car();
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            //composition == 'has a ..' (lifecycle dependent)
            Project p = new Project(m);
        }
    }
}
