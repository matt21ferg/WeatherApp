using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("AppSettingsRepo.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();
                       

            Console.WriteLine("what is your zip code?\n");
            var zipCode = Console.ReadLine();

            var apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine($"it is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location");
            
            
        
        


        
            
        
        }
    }
}
