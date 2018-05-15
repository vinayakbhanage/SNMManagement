namespace SNMManagement.Services.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SNMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SNMContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var khetra = new List<Khetra> {
                new Models.Khetra(){ Id=1, Name="Mumbai 1" },
                new Models.Khetra(){ Id=2, Name="Mumbai 2" }
            };

            khetra.ForEach(k => context.Khetras.Add(k));
            context.SaveChanges();

            var Units = new List<Unit> {
                new Unit() { Id= 1, Name="Delisle Road", Location="Delisle Road, Mumbai", UnitNumber=204, KhetraId =1 },
                new Unit() { Id= 2, Name="Lower Parel", Location="Lower Parel, Mumbai", UnitNumber=1359, KhetraId =1 }
            };

            Units.ForEach(u => context.Units.Add(u));
            context.SaveChanges();

            var Areas = new List<Area> {
                new Models.Area() { Id = 1, UnitId = 1, Name = "Delisle Road", Location = "Delisle Road N M joshi School" },
                new Models.Area() { Id = 2, UnitId = 1, Name = "Byculla", Location = "Byculla Municiple school" },
                new Models.Area() { Id = 3, UnitId = 2, Name = "Lower Parel", Location = "Lower Parel Municiple School" }
            };

            Areas.ForEach(a => context.Areas.Add(a));
            context.SaveChanges();

            var SatsangTypes = new List<SatsangType> {
                new SatsangType() { Id = 1, Type = "WEEKLY", Description = "Weekly Satsang" },
                new SatsangType() { Id = 2, Type = "GENERAL", Description = "General Satsang" },
                new SatsangType() { Id = 3, Type = "NARI", Description = "Nari Satsang" },
                new SatsangType() { Id = 4, Type = "SAMAGAM", Description = "Samagam" }
            };

            SatsangTypes.ForEach(s => context.SatsangTypes.Add(s));
            context.SaveChanges();

            var SewadarDesignations = new List<SewadarDesignation> {
                new SewadarDesignation() { Id = 1, Name = "Sewadar", Description = "Sewadar" },
                new SewadarDesignation() { Id = 2, Name = "Shikshak", Description = "Shikshak" },
                new SewadarDesignation() { Id = 3, Name = "Sanchalak", Description = "Sanchalak" }
            };

            SewadarDesignations.ForEach(s => context.SewadarDesignations.Add(s));
            context.SaveChanges();

            var DutyGroups = new List<DutyGroup> {
                new DutyGroup() { Id = 1, Name = "Duty Group 1", UnitId = 1 },
                new DutyGroup() { Id = 2, Name = "Duty Group 2", UnitId = 1 },
                new DutyGroup() { Id = 3, Name = "Duty Group 3", UnitId = 1 },
                new DutyGroup() { Id = 4, Name = "Duty Group 4", UnitId = 1 }
            };

            DutyGroups.ForEach(d => context.DutyGroups.Add(d));
            context.SaveChanges();

            var DutyCharts = new List<DutyChart> {
                new DutyChart() { Id = 1, Year = 2017, Month = 1, MonthDesc = "JAN", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 2, Year = 2017, Month = 2, MonthDesc = "FEB", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 3, Year = 2017, Month = 3, MonthDesc = "MAR", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 4, Year = 2017, Month = 4, MonthDesc = "APR", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 5, Year = 2017, Month = 5, MonthDesc = "MAY", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 6, Year = 2017, Month = 6, MonthDesc = "JUN", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 7, Year = 2017, Month = 7, MonthDesc = "JUL", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 8, Year = 2017, Month = 8, MonthDesc = "AUG", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 9, Year = 2017, Month = 9, MonthDesc = "SEP", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 10, Year = 2017, Month = 10, MonthDesc = "OCT", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 11, Year = 2017, Month = 11, MonthDesc = "NOV", DutyGroupId = 1, AreaId = 1 },
                new DutyChart() { Id = 12, Year = 2017, Month = 12, MonthDesc = "DEC", DutyGroupId = 1, AreaId = 1 },
            };

            DutyCharts.ForEach(d => context.DutyCharts.Add(d));
            context.SaveChanges();

            var Mahatmas = new List<Mahatma> {
                new Models.Mahatma() { Id = 1, FirstName = "VINAYAK", MiddleName = "VISHNU", LastName = "BHANAGE", Gender = "Male", BloodGroup = "O +VE", DOB = new DateTime(1984,2,1), ResidentialAddress = "724 Potomac Rd, Atlanta, GA, USA, 30338", PermanentAddress = "18/100, HARARWALA BLDG, N. M. JOSHI MARG, LOWER PAREL, MUMBAI, MAHARASHTRA, INDIA", Mobile = "4049362703", OfficeAddress = null, OfficeTelephone = null, GyanTakenYear = null, CorpusAccountNo = null, FamilyCount = null, Qualification = "Batchlor in Computer Science", Occupation = "Software Engineer", SpecialQualities = null, Photo = null },
                new Models.Mahatma() { Id = 2, FirstName = "VASANT", MiddleName = "", LastName = "PATADE", Gender = "Male", BloodGroup = "A +VE", DOB = new DateTime(1982, 12, 17), ResidentialAddress = "Mumbai, Maharashtra, India", PermanentAddress = "MUMBAI, MAHARASHTRA, INDIA", Mobile = "9833418862", OfficeAddress = null, OfficeTelephone = null, GyanTakenYear = null, CorpusAccountNo = null, FamilyCount = null, Qualification = "Batchlor", Occupation = "Enterprenuer", SpecialQualities = null, Photo = null }
            };

            Mahatmas.ForEach(u => context.Mahatmas.Add(u));
            context.SaveChanges();

            var Sewadars = new List<Sewadar> {
                new Models.Sewadar() { ID = 1, PersonalNo = "277", ICardNumber = 123456, WeeklyHoliday="Sunday", Wing = 1, MahatmaId = 1, SewadarDesignationId = 1 },
                new Models.Sewadar() { ID = 2, PersonalNo = "208", ICardNumber = 456789, WeeklyHoliday="Sunday", Wing = 1, MahatmaId = 2, SewadarDesignationId = 1 }
            };

            Sewadars.ForEach(s => context.Sewadars.Add(s));
            context.SaveChanges();

            var Satsangs = new List<Satsang> {
                new Satsang() { Id = 1, Title = "K1-204-Delisle Road-20171201-GENERAL", Note = "Test", SatsangTypeId = 1, Date = new DateTime(2017,12,1), StageDutyMahatmaName = "Vasant Patade", UnitId = 1, AreaId = 1, SanchalakId = 1, CreatedBy = null },
                new Satsang() { Id = 2, Title = "K1-204-Delisle Road-20171207-GENERAL", Note = "Test", SatsangTypeId = 1, Date = new DateTime(2017,12,7), StageDutyMahatmaName = "Sudarshan Sawant", UnitId = 1, AreaId = 1, SanchalakId = 1, CreatedBy = null }
            };

            Satsangs.ForEach(s => context.Satsangs.Add(s));
            context.SaveChanges();

            var Attendences = new List<Attendance> {
                new Attendance() { Id = 1, SatsangId = 1, SewadarId = 1, AttendanceStatus = "P", Remarks = "Present" },
                new Attendance() { Id = 2, SatsangId = 1, SewadarId = 2, AttendanceStatus = "P", Remarks = "Present" },
                new Attendance() { Id = 3, SatsangId = 2, SewadarId = 2, AttendanceStatus = "P", Remarks = "Present" }
            };

            Attendences.ForEach(a => context.Attendances.Add(a));
            context.SaveChanges();
        }
    }
}
