using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess.Models
{
    public class DutyChart
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public int Month { get; set; }

        public string MonthDesc { get; set; }

        public int AreaId { get; set; }

        public Nullable<int> Year { get; set; }

        
        public Area Area { get; set; }

        public DutyGroup DutyGroup { get; set; }
    }
}
