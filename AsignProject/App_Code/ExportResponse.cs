using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ExportResponse 的摘要说明
/// </summary>
public class ExportResponse
{
    public void ExportJson(object data)
    {
        string json = JsonConvert.SerializeObject(data);
        System.Web.HttpContext.Current.Response.ContentType = "text/json;charset=utf-8";
        HttpContext.Current.Response.Write(json);
        HttpContext.Current.Response.End();
    }

}