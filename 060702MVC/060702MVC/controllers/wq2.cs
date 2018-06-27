using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTEST.controllers
{
    public class wq2
    {
        Student s = new Student
        {
            Class = new ClassInfo { Classname = "一年一班", Classno = 2 },
            Stuname = "武二",
            Stuno = 5,
            Ismale = true
        };
        public object ShowAllInfo(Student s)
        {
            //ArrayList result = new ArrayList();
            //result.Add(s.Ismale);
            //result.Add(s.Class);
            //result.Add(s.Stuname);
            //result.Add(s.Stuno);
            return s;
        }
    }

}



