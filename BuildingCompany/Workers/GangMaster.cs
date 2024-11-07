using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCompany.Staff
{
    internal class GangMaster : IWorker
    {
        public string Name { get; set; }

        public GangMaster(string name)
        {
            Name = name;
        }


        public float CalculateSalary()
        {
            var salary = 0;
            return salary;
        }

    }
}
