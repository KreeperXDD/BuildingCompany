using BuildingCompany.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuildingCompany.Manager
{
    internal class StaffManager : IManager
    {
        private List<string> _freeWorkers = new List<string>();

        public List<string> CreateNewBrigade(DateTime date)
        {
            CheckFreeWorkers(date);

            List<string> brigade = new List<string>();

            // набор пероснала, какая-то лоигка

            return brigade;
        }

        private void CheckFreeWorkers(DateTime date)
        {
            _freeWorkers.Clear();

            foreach (var workerName in StaffSchedule.Load.Keys)
            {
                if (!StaffSchedule.Load[workerName].Contains(date))
                {
                    _freeWorkers.Add(workerName);
                }
            }
        }

    }
}