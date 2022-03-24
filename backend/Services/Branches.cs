namespace backend.Services
{
    public class Branches
    {
           private const string url = "http://localhost:8080/branches";

        public async IEnumerable<Branches> GetBranches()
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = result.Content.ReadAsStringAsync();

        }
    }
}