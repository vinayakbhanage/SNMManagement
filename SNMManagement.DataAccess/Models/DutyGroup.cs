using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class DutyGroup
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Nullable<decimal> UnitId { get; set; }


        public IEnumerable<DutyChart> DutyCharts { get; set; }

        public Unit Unit { get; set; }
    }
}
