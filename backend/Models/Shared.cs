using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Shared
    {
        public class Accessibility
        {
            public string description { get; set; }
            public string type { get; set; }
        }

        public class Accessibilities
        {
            public List<Accessibility> Accessibility { get; set; }
        }
    }
}
