﻿using AsignProject.DAL;
using AsignProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignProjectBLL
{
    public class StudentManager
    {
        private StudentService ss = new StudentService();
         public Student Login(int sid,ref bool res)
        {
            res = false;
            Student s = ss.Login(sid);
            res = s == null ? false : true;
            return s;
        }
    }
}
