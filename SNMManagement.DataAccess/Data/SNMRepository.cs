using SNMManagement.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess
{
    public class MahatmaRepository : IMahatmaRepository
    {
        public SNMContext dbContext = null;

        public MahatmaRepository(SNMContext context)
        {
            dbContext = context;
        }

        public IEnumerable<Mahatma> SelectAll()
        {
            return dbContext.Mahatma.ToList();
        }

        public Mahatma GetById(int Id)
        {
            return dbContext.Mahatma.Find(Id);
        }

        public void Insert(Mahatma obj)
        {
            dbContext.Mahatma.Add(obj);
            Save();
        }

        public void Update(Mahatma obj)
        {
            dbContext.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int Id)
        {
            Mahatma oMahatma = dbContext.Mahatma.Find(Id);
            dbContext.Mahatma.Remove(oMahatma);
            Save();
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }

    public class SewadarRepository : ISewadarRepository
    {
        SNMContext db = null;

        public SewadarRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<Sewadar> SelectAll()
        {
            var Sewadar = db.Sewadar;
            return Sewadar.ToList();
        }

        public Sewadar GetById(int id)
        {
            return db.Sewadar.Find(id);
        }

        public void Insert(Sewadar obj)
        {
            db.Sewadar.Add(obj);
            Save();
        }

        public void Update(Sewadar obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Sewadar sewadar = db.Sewadar.Find(id);
            db.Sewadar.Remove(sewadar);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class AreaRepository : IAreaRepository
    {
        SNMContext db = null;

        public AreaRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<Area> SelectAll()
        {
            var Area = db.Area;
            return Area.ToList();
        }

        public Area GetById(int id)
        {
            return db.Area.Find(id);
        }

        public void Insert(Area obj)
        {
            db.Area.Add(obj);
            Save();
        }

        public void Update(Area obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Area Area = db.Area.Find(id);
            db.Area.Remove(Area);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class AttendanceRepository : IAttendanceRepository
    {
        SNMContext db = null;

        public AttendanceRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<Attendance> SelectAll()
        {
            var Attendance = db.Attendance;
            return Attendance.ToList();
        }

        public Attendance GetById(int id)
        {
            return db.Attendance.Find(id);
        }

        public void Insert(Attendance obj)
        {
            db.Attendance.Add(obj);
            Save();
        }

        public void Update(Attendance obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Attendance Attendance = db.Attendance.Find(id);
            db.Attendance.Remove(Attendance);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class DutyChartRepository : IDutyChartRepository
    {
        SNMContext db = null;

        public DutyChartRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<DutyChart> SelectAll()
        {
            var DutyChart = db.DutyChart;
            return DutyChart.ToList();
        }

        public DutyChart GetById(int id)
        {
            return db.DutyChart.Find(id);
        }

        public void Insert(DutyChart obj)
        {
            db.DutyChart.Add(obj);
            Save();
        }

        public void Update(DutyChart obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            DutyChart DutyChart = db.DutyChart.Find(id);
            db.DutyChart.Remove(DutyChart);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class DutyGroupRepository : IDutyGroupRepository
    {
        SNMContext db = null;

        public DutyGroupRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<DutyGroup> SelectAll()
        {
            var DutyGroup = db.DutyGroup;
            return DutyGroup.ToList();
        }

        public DutyGroup GetById(int id)
        {
            return db.DutyGroup.Find(id);
        }

        public void Insert(DutyGroup obj)
        {
            db.DutyGroup.Add(obj);
            Save();
        }

        public void Update(DutyGroup obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            DutyGroup DutyGroup = db.DutyGroup.Find(id);
            db.DutyGroup.Remove(DutyGroup);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class KhetraRepository : IKhetraRepository
    {
        SNMContext db = null;

        public KhetraRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<Khetra> SelectAll()
        {
            var Khetra = db.Khetra;
            return Khetra.ToList();
        }

        public Khetra GetById(int id)
        {
            return db.Khetra.Find(id);
        }

        public void Insert(Khetra obj)
        {
            db.Khetra.Add(obj);
            Save();
        }

        public void Update(Khetra obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Khetra Khetra = db.Khetra.Find(id);
            db.Khetra.Remove(Khetra);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class SatsangRepository : ISatsangRepository
    {
        SNMContext db = null;

        public SatsangRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<Satsang> SelectAll()
        {
            var Satsang = db.Satsang;
            return Satsang.ToList();
        }

        public Satsang GetById(int id)
        {
            return db.Satsang.Find(id);
        }

        public void Insert(Satsang obj)
        {
            db.Satsang.Add(obj);
            Save();
        }

        public void Update(Satsang obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Satsang Satsang = db.Satsang.Find(id);
            db.Satsang.Remove(Satsang);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class SatsangTypeRepository : ISatsangTypeRepository
    {
        SNMContext db = null;

        public SatsangTypeRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<SatsangType> SelectAll()
        {
            var SatsangType = db.SatsangType;
            return SatsangType.ToList();
        }

        public SatsangType GetById(int id)
        {
            return db.SatsangType.Find(id);
        }

        public void Insert(SatsangType obj)
        {
            db.SatsangType.Add(obj);
            Save();
        }

        public void Update(SatsangType obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            SatsangType SatsangType = db.SatsangType.Find(id);
            db.SatsangType.Remove(SatsangType);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class SewadarDesignationRepository : ISewadarDesignationRepository
    {
        SNMContext db = null;

        public SewadarDesignationRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<SewadarDesignation> SelectAll()
        {
            var SewadarDesignation = db.SewadarDesignation;
            return SewadarDesignation.ToList();
        }

        public SewadarDesignation GetById(int id)
        {
            return db.SewadarDesignation.Find(id);
        }

        public void Insert(SewadarDesignation obj)
        {
            db.SewadarDesignation.Add(obj);
            Save();
        }

        public void Update(SewadarDesignation obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            SewadarDesignation SewadarDesignation = db.SewadarDesignation.Find(id);
            db.SewadarDesignation.Remove(SewadarDesignation);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class UnitRepository : IUnitRepository
    {
        SNMContext db = null;

        public UnitRepository(SNMContext db)
        {
            this.db = db;
        }

        public IEnumerable<Unit> SelectAll()
        {
            var Unit = db.Unit;
            return Unit.ToList();
        }

        public Unit GetById(int id)
        {
            return db.Unit.Find(id);
        }

        public void Insert(Unit obj)
        {
            db.Unit.Add(obj);
            Save();
        }

        public void Update(Unit obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(int id)
        {
            Unit Unit = db.Unit.Find(id);
            db.Unit.Remove(Unit);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
