using HouseInfoProject.BLL;
using HouseInfoProject.Model;
using HouseInfoProject.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseInfoProject.controllers
{
    [AttrInfo(ClassName ="house")]
    public class housescontroller
    {
        public HouseManager Hm { set; get; }
        [AttrInfo(MethodName ="all.action")]
        public List<House> GetAllHouse()
        {
            return Hm.GetAllHouse();
        }
        public bool AddHouse(House h)
        {
            return Hm.AddHouse(h);
        }
        public bool DeleteHouseById(int id)
        {
            return Hm.DeleteHouseById(id);
        }
    }
}