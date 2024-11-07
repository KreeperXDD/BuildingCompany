using BuildingCompany.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuildingCompany.Manager
{
    internal class StaffManager : IManager
    {
        private List<string> _freeWorkers = [];

        public List<string> CreateNewBrigade(DateTime date)
        {
            CheckFreeWorkers(date);

            List<string> brigade = [];

            // набор пероснала, какая-то лоигка

            return brigade;
        }

        private void CheckFreeWorkers(DateTime date)
        {
            _freeWorkers.Clear();

            foreach (var workerName in StaffSchedule.Load)
            {
                if (workerName.Date != date)
                {
                    _freeWorkers.Add(workerName.Name);
                }
            }
        }
        public void WorkerRegistration(List<IWorker> workers)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                StaffSchedule.AddNewWorker(workers[i]);
            }
        }
    }
}