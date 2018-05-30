using HouseProject.DAL;
using HouseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject.Manager
{
   public class HouseManager
    {
        private HouseService hs = new HouseService();
        public List<House> GetAllHouse()
        {
            return hs.GetAllHouse();
        }
        public bool AddHouse(House h)
        {
            return hs.AddHouse(h);
        }
        public bool DeleteHouseById(int id)
        {
            return hs.DeleteHouseById(id);
        }
    }
}
