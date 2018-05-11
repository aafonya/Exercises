using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAssociation
{
    class Manager
    {
        Employee[] employees;
        public void Travel(Car c)
        {
            c.Drive(this);
        }
    }
}
