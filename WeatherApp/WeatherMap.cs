using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace WeatherApp
{
    public class WeatherMap
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();

            var response = client.GetAsync(apiCall).Result.ToString();

           var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
           
            return temp;
        }

    }
}
