using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Info 的摘要说明
/// </summary>
public class Info
{
    private int _code;
    private string _desc;
    public Info()
    {
       
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public Info(int _code, string _desc)
    {
        this.Code = _code;
        this.Desc = _desc;
    }

    public int Code
    {
        get
        {
            return _code;
        }

        set
        {
            _code = value;
        }
    }

    public string Desc
    {
        get
        {
            return _desc;
        }

        set
        {
            _desc = value;
        }
    }

}