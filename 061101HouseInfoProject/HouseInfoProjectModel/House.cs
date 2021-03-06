﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseInfoProject.Model
{
    [DeBugInfo("", "test_0530houses")]
    public class House
    {
        private int _houseId;
        private string _houseTypeName;
        private int _area;
        private string _addr;
        //private float _price;
        private Customers _customerinfo;
        public House() { }

        public House(int _houseId, string _houseTypeName, int _area, string _addr, float _price, Customers _customerinfo)
        {
            this._houseId = _houseId;
            this._houseTypeName = _houseTypeName;
            this._area = _area;
            this._addr = _addr;
            //this._price = _price;
            this._customerinfo = _customerinfo;
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



        //public float Price
        //{
        //    get
        //    {
        //        return _price;
        //    }

        //    set
        //    {
        //        _price = value;
        //    }
        //}

        public Customers Customerinfo
        {
            get
            {
                return _customerinfo;
            }

            set
            {
                _customerinfo = value;
            }
        }
    }
}
