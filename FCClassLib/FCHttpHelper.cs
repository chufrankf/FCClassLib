using System;
using System.Reflection;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace FCClassLib
{
    public static class FCHttpHelper
    { 
        public static async Task<string> GetTaskAsync(HttpClient client, string url, Dictionary<string, string> headers = null)
        {
            string result = null;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.BasicHttp.JsonContent));
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }
            
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }
    }
}
