using SampleService.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Domain.Entities
{
    public class Menu :BaseEntity
    {
        public required string Name { get; set; }

        public required ICollection<EndPoint> Endpoints { get; set; }
    }
}
