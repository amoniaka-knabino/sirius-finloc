using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapController : ControllerBase
    {
        private BranchesService _branchService;
        private DevicesService _deviceService;

        public MapController(BranchesService branchService, DevicesService deviceService)
        {
            _branchService = branchService;
            _deviceService = deviceService;
        }

        [HttpPost]
        public async Task<ActionResult<Response>> Post([FromBody] Filter filter)
        {
            try
            {
                var response = new Response();

                var branches = await _branchService.GetBranches();
                var devices = await _deviceService.GetDevices();

                response.Branches = branches.Where(b =>
                    b.wifi == filter.wifi
                    && b.equeue == filter.equeue
                    && b.Information.Availability.access24Hours == filter.access24Hourse);

                response.Devices = devices.Where(d =>
                    d.Availability.access24Hours == filter.access24Hourse);

                if (filter.Accessibilities != null
                    && filter.Accessibilities.Any())
                {
                    response.Branches = response.Branches.Where(b =>
                      filter.Accessibilities.All(a => b.Accessibilities.Accessibility
                        .Select(ac => ac.type).Contains(a.ToDescription())));

                    response.Devices = response.Devices.Where(d =>
                       filter.Accessibilities.All(a => d.Accessibilities.Accessibility
                        .Select(ac => ac.type).Contains(a.ToDescription())));
                }

                if (filter.Cards != null
                    && filter.Cards.Any())
                {
                    response.Devices = response.Devices.Where(d =>
                       filter.Cards.All(c => d.cards.Contains(c.ToDescription())));
                }

                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
