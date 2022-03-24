using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using backend.Model;
using backend.Model.Devices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace backend.Services
{
    public class DevicesService
    {
        private string _url;
        public DevicesService(string url)
        {
            _url = url + "/devices";
        }
        public async Task<List<Device>> GetDevices()
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(_url);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Root>(content)?.Data.Device;
        }
    }
}