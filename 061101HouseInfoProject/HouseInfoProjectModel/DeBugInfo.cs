using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInfoProject.Model
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property)]
    public class DeBugInfo:Attribute
    {
        private string _columnname;
        private string _tablename;

        public DeBugInfo(string _columnname, string _tablename)
        {
            this.Columnname = _columnname;
            this.Tablename = _tablename;
        }

        public string Columnname
        {
            get
            {
                return _columnname;
            }

            set
            {
                _columnname = value;
            }
        }

        public string Tablename
        {
            get
            {
                return _tablename;
            }

            set
            {
                _tablename = value;
            }
        }
    }
}
