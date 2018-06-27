using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseInfoProject.MVC
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class AttrInfo:Attribute
    {
        private string _className;
        private string _methodName;

        public AttrInfo(string _className, string _methodName)
        {
            this.ClassName = _className;
            this.MethodName = _methodName;
        }
        public AttrInfo() { }
        public string ClassName
        {
            get
            {
                return _className;
            }

            set
            {
                _className = value;
            }
        }

        public string MethodName
        {
            get
            {
                return _methodName;
            }

            set
            {
                _methodName = value;
            }
        }
    }
}