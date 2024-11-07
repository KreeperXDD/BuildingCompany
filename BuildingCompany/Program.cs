using BuildingCompany.Staff;
using BuildingCompany.Manager;

namespace BuildingCompany
{    
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            var manager = new MainManager();
            var gangMasters = new List<IWorker>();
            

            string name = "dadaday";

            for (int i = 0; i >= 0 ;i++)
            {
                //парсим наш блокнот
                gangMasters.Add(new GangMaster(name));
            }

            manager.Test(gangMasters.ToArray());
            manager.CreateNewOrder();

            manager.GetFeedback();
        }
    }
}