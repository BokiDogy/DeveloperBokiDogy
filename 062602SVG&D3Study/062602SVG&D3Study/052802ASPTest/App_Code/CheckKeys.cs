using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// CheckKeys 的摘要说明
/// </summary>
public static class CheckKeys
{
    private static string _nowkey="";

    public static string Nowkey
    {
        get
        {
            return _nowkey;
        }

        set
        {
            _nowkey = value;
        }
    }

    private static Hashtable CheckHeader(string key)
    {
        Info ifs = null;
        if (key == null)
        {
            ifs = new Info(2001, "错误");

        }
        else if (key != Nowkey)
        {
            ifs = new Info(2002, "令牌错误");

        }
        else
        {
            ifs = new Info(200, "获取成功");
        }
        Hashtable ht = new Hashtable();
        ht.Add("info", ifs);
        ht.Add("data", null);
        return ht;
    }
    public static string GetData(string header,object scucessdata)
    {
        Hashtable ht = CheckHeader(header);
        Info ifs = (Info)ht["info"];
        object data = ifs.Code == 200 ? scucessdata : null;
        ht["data"] = data;
        string json = JsonConvert.SerializeObject(ht);
        return json;
    }

}