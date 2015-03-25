using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace Utilities
{
    public class JSON
    {
        public static string GetJsonObjectFromURL(string URL)
        {
            var json = new WebClient().DownloadString(URL);
            return json;
        }

        public static List<object> DeserializeJsonObject(String json)
        {
            var jsonObject = JsonConvert.DeserializeObject<List<object>>(json);
            return jsonObject;
        }
    }
}