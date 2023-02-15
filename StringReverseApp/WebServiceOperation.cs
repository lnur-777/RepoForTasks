using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseClient
{
    public class WebServiceOperation
    {
       public async Task<string> ReadApiData(string url, string parameter)
        {
            var baseAddress = $"{url}?text={parameter}";
            var responseData = "";

            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(baseAddress).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    }
                }
            }
            return responseData;
        }

    }
}
