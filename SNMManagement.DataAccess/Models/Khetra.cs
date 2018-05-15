using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class Khetra
    {
        public decimal ID { get; set; }

        public string Name { get; set; }

        public IEnumerable<Unit> Units { get; set; }
    }
}
