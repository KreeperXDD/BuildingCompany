using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using BuildingCompany.Staff;

namespace BuildingCompany.Manager
{
    internal class MainManager : IManager
    {
        private StaffManager _staffManager = new();
        private FacilityManager _facilityManager = new();

        public void CreateNewOrder(DateTime date)
        {
            List<string> brigade = _staffManager.CreateNewBrigade(date);
            _facilityManager.CreateNewFacility(brigade);
        }

        public void GetFeedback()
        {

        }

        public void Test(IWorker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                StaffSchedule.AddNewWorker(workers[i]);
            }
        }

    }
}
