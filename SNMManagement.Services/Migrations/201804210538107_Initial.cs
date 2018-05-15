namespace SNMManagement.Services.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.DutyCharts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Month = c.Int(),
                        MonthDesc = c.String(),
                        Year = c.Int(),
                        AreaId = c.Int(nullable: false),
                        DutyGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.DutyGroups", t => t.DutyGroupId, cascadeDelete: true)
                .Index(t => t.AreaId)
                .Index(t => t.DutyGroupId);
            
            CreateTable(
                "dbo.DutyGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: false)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitNumber = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        KhetraId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Khetras", t => t.KhetraId, cascadeDelete: false)
                .Index(t => t.KhetraId);
            
            CreateTable(
                "dbo.Khetras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satsangs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Note = c.String(),
                        Date = c.DateTime(nullable: false),
                        StageDutyMahatmaName = c.String(),
                        SanchalakId = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedBy = c.String(),
                        AreaId = c.Int(nullable: false),
                        SatsangTypeId = c.Int(nullable: false),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.SatsangTypes", t => t.SatsangTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: false)
                .Index(t => t.AreaId)
                .Index(t => t.SatsangTypeId)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AttendanceStatus = c.String(nullable: false),
                        Remarks = c.String(),
                        SatsangId = c.Int(nullable: false),
                        SewadarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Satsangs", t => t.SatsangId, cascadeDelete: true)
                .ForeignKey("dbo.Sewadars", t => t.SewadarId, cascadeDelete: true)
                .Index(t => t.SatsangId)
                .Index(t => t.SewadarId);
            
            CreateTable(
                "dbo.Sewadars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonalNo = c.String(nullable: false),
                        ICardNumber = c.Int(nullable: false),
                        WeeklyHoliday = c.String(nullable: false),
                        Wing = c.Int(nullable: false),
                        MahatmaId = c.Int(nullable: false),
                        SewadarDesignationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Mahatmas", t => t.MahatmaId, cascadeDelete: true)
                .ForeignKey("dbo.SewadarDesignations", t => t.SewadarDesignationId, cascadeDelete: true)
                .Index(t => t.MahatmaId)
                .Index(t => t.SewadarDesignationId);
            
            CreateTable(
                "dbo.Mahatmas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        BloodGroup = c.String(),
                        DOB = c.DateTime(nullable: false),
                        ResidentialAddress = c.String(),
                        PermanentAddress = c.String(),
                        Mobile = c.String(nullable: false),
                        OfficeAddress = c.String(),
                        OfficeTelephone = c.String(),
                        GyanTakenYear = c.String(),
                        CorpusAccountNo = c.String(),
                        FamilyCount = c.Int(),
                        Qualification = c.String(),
                        Occupation = c.String(),
                        SpecialQualities = c.String(),
                        Photo = c.Binary(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SewadarDesignations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SatsangTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DutyCharts", "DutyGroupId", "dbo.DutyGroups");
            DropForeignKey("dbo.Satsangs", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Satsangs", "SatsangTypeId", "dbo.SatsangTypes");
            DropForeignKey("dbo.Sewadars", "SewadarDesignationId", "dbo.SewadarDesignations");
            DropForeignKey("dbo.Sewadars", "MahatmaId", "dbo.Mahatmas");
            DropForeignKey("dbo.Attendances", "SewadarId", "dbo.Sewadars");
            DropForeignKey("dbo.Attendances", "SatsangId", "dbo.Satsangs");
            DropForeignKey("dbo.Satsangs", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.Units", "KhetraId", "dbo.Khetras");
            DropForeignKey("dbo.DutyGroups", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Areas", "UnitId", "dbo.Units");
            DropForeignKey("dbo.DutyCharts", "AreaId", "dbo.Areas");
            DropIndex("dbo.Sewadars", new[] { "SewadarDesignationId" });
            DropIndex("dbo.Sewadars", new[] { "MahatmaId" });
            DropIndex("dbo.Attendances", new[] { "SewadarId" });
            DropIndex("dbo.Attendances", new[] { "SatsangId" });
            DropIndex("dbo.Satsangs", new[] { "UnitId" });
            DropIndex("dbo.Satsangs", new[] { "SatsangTypeId" });
            DropIndex("dbo.Satsangs", new[] { "AreaId" });
            DropIndex("dbo.Units", new[] { "KhetraId" });
            DropIndex("dbo.DutyGroups", new[] { "UnitId" });
            DropIndex("dbo.DutyCharts", new[] { "DutyGroupId" });
            DropIndex("dbo.DutyCharts", new[] { "AreaId" });
            DropIndex("dbo.Areas", new[] { "UnitId" });
            DropTable("dbo.SatsangTypes");
            DropTable("dbo.SewadarDesignations");
            DropTable("dbo.Mahatmas");
            DropTable("dbo.Sewadars");
            DropTable("dbo.Attendances");
            DropTable("dbo.Satsangs");
            DropTable("dbo.Khetras");
            DropTable("dbo.Units");
            DropTable("dbo.DutyGroups");
            DropTable("dbo.DutyCharts");
            DropTable("dbo.Areas");
        }
    }
}
