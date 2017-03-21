using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FCClassLib
{
    public static class FCoreHelpers
    {
        public static string ToQueryString(this IDictionary<string, string> dict)
        {
            var array = (from key in dict.Keys
                         select string.Format("{0}={1}", key, dict[key])).ToArray();
            return string.Join("&", array);
        }
    }
}
