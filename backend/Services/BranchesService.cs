using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using backend.Models;
using backend.Models.Branches;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace backend.Services
{
    public class BranchesService
    {
        private string _url;
        public BranchesService(string url)
        {
            _url = url + "/branches";
        }
        public async Task<List<Branch>> GetBranches()
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(_url);
            var content = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Root>(content)?.Data.Branch;
        }

        public IEnumerable<Branch> GetFiltredBranches(IEnumerable<Branch> branches, Filter filter)
        {
            // to do
            return default;
        }
    }
}