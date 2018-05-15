using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class SewadarDesignation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Sewadar> Sewadars { get; set; }
    }
}
