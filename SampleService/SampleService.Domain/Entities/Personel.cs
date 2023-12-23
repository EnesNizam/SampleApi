using SampleService.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Domain.Entities
{
    public class Personel : BaseEntity
    {
        public required string Adi { get; set; }
    }
}
