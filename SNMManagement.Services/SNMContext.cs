using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

public class SNMContext : DbContext
{
    // You can add custom code to this file. Changes will not be overwritten.
    // 
    // If you want Entity Framework to drop and regenerate your database
    // automatically whenever you change your model schema, please use data migrations.
    // For more information refer to the documentation:
    // http://msdn.microsoft.com/en-us/data/jj591621.aspx

    public SNMContext() : base("name=SNMContext")
    {
    }

    public System.Data.Entity.DbSet<SNMManagement.Models.Mahatma> Mahatmas { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.Sewadar> Sewadars { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.SewadarDesignation> SewadarDesignations { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.Khetra> Khetras { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.Area> Areas { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.Unit> Units { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.Attendance> Attendances { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.Satsang> Satsangs { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.DutyChart> DutyCharts { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.DutyGroup> DutyGroups { get; set; }

    public System.Data.Entity.DbSet<SNMManagement.Models.SatsangType> SatsangTypes { get; set; }
}
