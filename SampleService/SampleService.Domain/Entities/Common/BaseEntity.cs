using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleService.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public int OlusturanKullaniciId { get; set; }
        public DateTime? DuzenlenmeTarihi { get; set; }
        public int? DuzenleyenKullaniciId { get; set; }
        public short KayitDurumu { get; set; }
    }
}
