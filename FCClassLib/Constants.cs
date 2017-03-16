using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FCClassLib
{
    public class Constants
    {

        public static class BasicHttp
        {
            public static string JsonContent = "application/json";

            public static Dictionary<string, HttpMethod> MethodDict = new Dictionary<string, HttpMethod>()
            {
                 {"GET"     ,   HttpMethod.Get}
                ,{"POST"    ,   HttpMethod.Post}
                ,{"PUT"     ,   HttpMethod.Put}
                ,{"DELETE"  ,   HttpMethod.Delete}
                ,{"TRACE"   ,   HttpMethod.Trace}
                ,{"HEAD"    ,   HttpMethod.Head}
                ,{"OPTIONS" ,   HttpMethod.Options}
            };
        }

        public static class GooglePlacesAPI
        {

        }
    }
}
