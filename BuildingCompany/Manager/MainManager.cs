using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BuildingCompany.Staff;

namespace BuildingCompany.Manager
{
    internal class MainManager : IManager
    {
        private StaffManager _staffManager = new();
        private FacilityManager _facilityManager = new();
        private List<IWorker> _workers = new();

        public void CreateNewOrder(DateTime date, string FacilityAdress)
        {
            List<string> brigade = _staffManager.CreateNewBrigade(date);
            _facilityManager.CreateNewFacility(brigade, FacilityAdress);
        }

        public void GetFeedback()
        {

        }

        public void SomeThing()
        {
            for (int i = 0; i>=0;i++)
            {
                //парсим блокнот
                var name = "aaa";
                _workers.Add(new GangMaster(name));
            }

            _staffManager.WorkerRegistration(_workers);
        }
    }
}
