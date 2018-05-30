using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProject.Model
{
    public class House
    {
        private int _houseId;
        private string _houseTypeName;
        private int _area;
        private string _addr;
        private Customers _customer;
        public House() { }
        public House(int _houseId, string _houseTypeName, int _area, string _addr, Customers _customer)
        {
            this._houseId = _houseId;
            this._houseTypeName = _houseTypeName;
            this._area = _area;
            this._addr = _addr;
            this._customer = _customer;
        }

        public int HouseId
        {
            get
            {
                return _houseId;
            }

            set
            {
                _houseId = value;
            }
        }

        public string HouseTypeName
        {
            get
            {
                return _houseTypeName;
            }

            set
            {
                _houseTypeName = value;
            }
        }

        public int Area
        {
            get
            {
                return _area;
            }

            set
            {
                _area = value;
            }
        }

        public string Addr
        {
            get
            {
                return _addr;
            }

            set
            {
                _addr = value;
            }
        }

        public Customers Customer
        {
            get
            {
                return _customer;
            }

            set
            {
                _customer = value;
            }
        }
    }
}
