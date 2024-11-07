using BuildingCompany.Staff;
using BuildingCompany.Manager;

namespace BuildingCompany
{
    internal class Program
    {
        private static DateTime _date;
        private static string _facilityAdress;

        private static void CreateNewAdress()
        {
            Console.WriteLine("pls write facility adress");
            _facilityAdress = Console.ReadLine();
        }

        private static void CreateNewDate()
        {
            Console.WriteLine("pls write works day, DD/MM/YYYY: ");
            _date = Convert.ToDateTime((Console.ReadLine()));
        }

        private static void Main(string[] args)
        {
            CreateNewDate();
            if(_date == null)
                CreateNewDate();
            CreateNewAdress();
            if(_facilityAdress == "")
                CreateNewAdress();
            
            var manager = new MainManager();

            manager.SomeThing();
            manager.CreateNewOrder(_date, _facilityAdress);
            manager.GetFeedback();
        }
    }
}