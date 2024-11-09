using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCompany.Manager
{
    internal class FacilityManager:IManager
    {
        private void MakeLog()
        {

        }

        public void CreateNewFacility(List<string> brigade, string facilityAdress)
        {
            //somelogic
            foreach(var worker in StaffSchedule.Load)
            {
                worker.FacilityAdress = facilityAdress;
            }
        }
    }
}
