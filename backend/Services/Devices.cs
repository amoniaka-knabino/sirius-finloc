namespace backend.Services
{
    public class Devices
    {
        private const string url = "http://localhost:8080/devices";

        public async IEnumerable<Devices> GetDevices()
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = result.Content.ReadAsStringAsync();

        }
    }
}