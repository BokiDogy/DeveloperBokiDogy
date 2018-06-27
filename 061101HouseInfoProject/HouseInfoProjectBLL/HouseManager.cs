using HouseInfoProject.DAL;
using HouseInfoProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInfoProject.BLL
{
    public class HouseManager
    {
        public HouseService Hs { set; get; }
        public List<House> GetAllHouse()
        {
            return Hs.GetAllHouse();
        }
        public bool AddHouse(House h)
        {
            return Hs.AddHouse(h);
        }
        public bool DeleteHouseById(int id)
        {
            return Hs.DeleteHouseById(id);
        }
    }
}
