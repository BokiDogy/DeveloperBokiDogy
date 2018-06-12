using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTEST.controllers
{
    public class wq1
    {
        public string show(string s,int d)
        {
            return $"s:{s},d:{d}";
        }
        public string eat()
        {
            return "就知道吃";
        }
        public void shownull(string s, int d)
        {
           
        }
    }
}