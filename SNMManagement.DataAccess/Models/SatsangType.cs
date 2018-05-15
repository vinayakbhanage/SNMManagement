using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class SatsangType
    {
        public decimal ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Satsang> Satsangs { get; set; }
    }
}
