using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using backend.Services;
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

        [HttpGet]
        public async Task<ActionResult<Response>> Get([FromQuery] Filter filter)
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


                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
