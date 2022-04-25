using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews()
        {

            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=793d39ad02ad85eb6a88eb9cced75e50&lang=sv&topic=sport");
            return JsonConvert.DeserializeObject<Root>(response);

        }





    }
}
