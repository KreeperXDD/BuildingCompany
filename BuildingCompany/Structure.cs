using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingCompany
{
    internal class Structure
    {
        public string Name;
        public DateTime Date;
        public string FacilityAdress;

        public Structure(string name, DateTime date = new(), string facilityAdress = "")
        {
            Name = name;
            Date = date;
            FacilityAdress = facilityAdress;
        }
    }
}
