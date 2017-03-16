using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace FCClassLib
{
    class FCUriHelper
    {
        private UriBuilder uriBuilder;
        private NameValueCollection parameters;

        public FCUriHelper()
        {
            uriBuilder = new UriBuilder();
            parameters = HttpUtility.ParseQueryString(String.Empty);
        }

        public FCUriHelper(string uri)
        {
            uriBuilder = new UriBuilder(uri);
            parameters = HttpUtility.ParseQueryString(String.Empty);
        }

        public FCUriHelper(string scheme, string host, int port, string pathValue)
        {
            uriBuilder = new UriBuilder(scheme, host, port, pathValue);
            parameters = HttpUtility.ParseQueryString(String.Empty);
        }

        public void AddParameters(string key, string value)
        {
            parameters.Add(key, value);
        }

        public Uri GetUri()
        {
            if (parameters.Count > 0)
            {
                uriBuilder.Query = parameters.ToString();
            }
            return uriBuilder.Uri;
        }
    }
}
