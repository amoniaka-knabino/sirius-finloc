using System.Collections.Generic;
using backend.Model.Devices;
using backend.Models.Branches;

namespace backend.Models
{
    public class Response
    {
        public IEnumerable<Branch> Branches { get; set; }
        public IEnumerable<Device> Devices { get; set; }
    }
}
