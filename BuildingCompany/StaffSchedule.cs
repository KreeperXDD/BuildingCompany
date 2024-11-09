using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingCompany.Staff;

namespace BuildingCompany
{
    static class StaffSchedule
    {
        public static List<Structure> Load = new();

        public static void EditLoad(IWorker worker, DateTime date)
        {
            foreach (var workerLoad in Load)
            {
                workerLoad.Date = date;
            }
        }

        public static void AddNewWorker(IWorker worker)
        { 
            Load.Add(new(worker.Name));
        }
    }
}
