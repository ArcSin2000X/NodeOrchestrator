using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Newtonsoft.Json;

namespace NodeBot.Utils
{
    public static class FormatConvert
    {
        public static string ObjToJSON(object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.None);
        }

        public static string JSONToQueryString(string json)
        {
            string str = "?";
            str += json.Replace(":","=").Replace("{","").Replace("}","").Replace(",","&").Replace("\"", "");
            return str;
        }

        public static string ToQueryString(object o)
        {
            string queryString = string.Empty;
            foreach (PropertyInfo property in o.GetType().GetProperties())
            {
                queryString += $"{property.Name}={property.GetValue(o)}&";
            }

            return $"?{queryString.Substring(0, queryString.Length-1)}";
        }

    }
}
