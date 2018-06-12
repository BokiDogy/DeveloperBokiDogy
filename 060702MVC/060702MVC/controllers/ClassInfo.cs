using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTEST.controllers
{
    public class ClassInfo
    {
        private int _classno;
        private string _classname;
        public ClassInfo() { }
        public ClassInfo(int _classno, string _classname)
        {
            this._classno = _classno;
            this._classname = _classname;
        }

        public int Classno
        {
            get
            {
                return _classno;
            }

            set
            {
                _classno = value;
            }
        }

        public string Classname
        {
            get
            {
                return _classname;
            }

            set
            {
                _classname = value;
            }
        }
    }
}