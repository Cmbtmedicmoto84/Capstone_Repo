using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorimotoCapstone.Helpers
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static List GetObjectFromJson<List>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(List) : JsonConvert.DeserializeObject<List>(value);
        }
    }
}
