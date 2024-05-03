using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session8.Utility
{
    public class JsonUtil
    {
        public static string Encode(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T Decode<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }


    }
}