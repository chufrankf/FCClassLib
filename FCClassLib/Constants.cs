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
        }

        public static class GooglePlacesAPI
        {
            public static string BaseUri = "https://maps.googleapis.com/maps/api/place";

            public static class OutputType
            {
                public static string Json = "json";
                public static string Xml = "xml";
            }

            public static class SearchExt
            {
                public static string Nearby = "nearbysearch";
                public static string Text = "textsearch";
                public static string Radar = "radarsearch";
                public static string Details = "details";
                public static string AutoComplete = "autocomplete";
            }

            public static class ParametersList
            {
                //Required
                public static string Key = "key";
                public static string Location = "location";
                public static string Radius = "radius";

                //Optional
                public static string Keyword = "keyword";
                public static string Language = "language";
                public static string MinPrice = "minprice";
                public static string MaxPrice = "maxprice";
                public static string Name = "name";
                public static string OpenNow = "opennow";
                public static string RankBy = "rankby";
                public static string Type = "type";
                public static string PageToken = "pagetoken";
            }
        }
    }
}
