using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCompany.Staff
{
    internal interface IWorker
    {
        string Name { get; set; }
        float CalculateSalary()
        {
            return 0;
        }
    }
}
