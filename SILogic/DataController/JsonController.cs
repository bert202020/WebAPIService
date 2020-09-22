using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SILogic.DataController
{
    public class JsonController
    {

        /*
         HttpClient httpClient = new HttpClient();
string request = "https://api.exmo.com/v1/currency";
HttpResponseMessage response = 
    (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();

JObject jObject = JObject.Parse(responseBody);
        */

        /*
        
        HttpClient httpClient = new HttpClient();

        string request = "https://api.exmo.com/v1/currency";
        HttpResponseMessage response =
            (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        JToken jArray = JToken.Parse(responseBody);
        //  Неявное преобразование в JArray
        List<string> list = jArray.ToObject<List<string>>();

        request = "https://api.exmo.com/v1/trades/?pair=BTC_USD,ETH_USD";
HttpResponseMessage response =
    (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        
            //  Неявное преобразование в JObject
            Dictionary<string, List<Order>> dict =
                jObject.ToObject<Dictionary<string, List<Order>>>();


            JToken jArray = JToken.Parse(responseBody);
            //  Неявное преобразование в JArray
            List<string> list = jArray.ToObject<List<string>>();


            string responseBody = await response.Content.ReadAsStringAsync();
            JToken jObject = JToken.Parse(responseBody);

            //  Неявное преобразование в JObject
            Dictionary<string, List<Order>> dict =
                jObject.ToObject<Dictionary<string, List<Order>>>();

        */
        public static JArray Extract(string data)
        {
            var jt = JArray.Parse(data);

            return jt;

        }

    }
}
