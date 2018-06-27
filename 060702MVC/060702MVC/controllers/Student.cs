using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTEST.controllers
{
    public class Student
    {
        private ClassInfo _class;
        private int _stuno;
        private string _stuname;
        private bool _ismale;
        public Student() { }
        public Student(ClassInfo _class, int _stuno, string _stuname, bool _ismale)
        {
            this._class = _class;
            this._stuno = _stuno;
            this._stuname = _stuname;
            this._ismale = _ismale;
        }

        public ClassInfo Class
        {
            get
            {
                return _class;
            }

            set
            {
                _class = value;
            }
        }

        public int Stuno
        {
            get
            {
                return _stuno;
            }

            set
            {
                _stuno = value;
            }
        }

        public string Stuname
        {
            get
            {
                return _stuname;
            }

            set
            {
                _stuname = value;
            }
        }

        public bool Ismale
        {
            get
            {
                return _ismale;
            }

            set
            {
                _ismale = value;
            }
        }
    }
}