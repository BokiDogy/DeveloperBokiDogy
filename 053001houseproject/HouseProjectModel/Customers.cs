using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject.Model
{
    public class Customers
    {
        private int _customerId;
        private string _loginName;
        private string _pwd;
        public Customers() { }
        public Customers(int _customerId, string _loginName, string _pwd)
        {
            this._customerId = _customerId;
            this._loginName = _loginName;
            this._pwd = _pwd;
        }

        public int CustomerId
        {
            get
            {
                return _customerId;
            }

            set
            {
                _customerId = value;
            }
        }

        public string LoginName
        {
            get
            {
                return _loginName;
            }

            set
            {
                _loginName = value;
            }
        }

        public string Pwd
        {
            get
            {
                return _pwd;
            }

            set
            {
                _pwd = value;
            }
        }
    }
}
