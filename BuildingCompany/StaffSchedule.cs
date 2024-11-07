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
        public static List<Tuple<string,DateTime,string>> Load = new List<Tuple<string, DateTime, string>>();

        public static void EditLoad(IWorker worker, DateTime date)
        {
            foreach (var workerLoad in Load)
            {
                workerLoad = date;
            }
        }

        public static void AddNewWorker(IWorker worker)
        {
            Load.Add(new(worker.Name, new DateTime(), ""));
        }

    }
}
