using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Domain.Entities.Identity
{
    public class AppRole : IdentityRole<string>
    {
        public required ICollection<EndPoint> Endpoints { get; set; }
    }
}
