using SNMManagement.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNMManagement.DataAccess
{
    public interface IMahatmaRepository
    {
        IEnumerable<Mahatma> SelectAll();
        Mahatma GetById(int Id);
        void Insert(Mahatma obj);
        void Update(Mahatma obj);
        void Delete(int Id);
        void Save();
    }

    public interface ISewadarRepository
    {
        IEnumerable<Sewadar> SelectAll();
        Sewadar GetById(int id);
        void Insert(Sewadar obj);
        void Update(Sewadar obj);
        void Delete(int id);
        void Save();
    }

    public interface IAreaRepository
    {
        IEnumerable<Area> SelectAll();
        Area GetById(int id);
        void Insert(Area obj);
        void Update(Area obj);
        void Delete(int id);
        void Save();
    }

    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> SelectAll();
        Attendance GetById(int id);
        void Insert(Attendance obj);
        void Update(Attendance obj);
        void Delete(int id);
        void Save();
    }

    public interface IDutyChartRepository
    {
        IEnumerable<DutyChart> SelectAll();
        DutyChart GetById(int id);
        void Insert(DutyChart obj);
        void Update(DutyChart obj);
        void Delete(int id);
        void Save();
    }

    public interface IDutyGroupRepository
    {
        IEnumerable<DutyGroup> SelectAll();
        DutyGroup GetById(int id);
        void Insert(DutyGroup obj);
        void Update(DutyGroup obj);
        void Delete(int id);
        void Save();
    }

    public interface IKhetraRepository
    {
        IEnumerable<Khetra> SelectAll();
        Khetra GetById(int id);
        void Insert(Khetra obj);
        void Update(Khetra obj);
        void Delete(int id);
        void Save();
    }

    public interface ISatsangRepository
    {
        IEnumerable<Satsang> SelectAll();
        Satsang GetById(int id);
        void Insert(Satsang obj);
        void Update(Satsang obj);
        void Delete(int id);
        void Save();
    }

    public interface ISatsangTypeRepository
    {
        IEnumerable<SatsangType> SelectAll();
        SatsangType GetById(int id);
        void Insert(SatsangType obj);
        void Update(SatsangType obj);
        void Delete(int id);
        void Save();
    }

    public interface ISewadarDesignationRepository
    {
        IEnumerable<SewadarDesignation> SelectAll();
        SewadarDesignation GetById(int id);
        void Insert(SewadarDesignation obj);
        void Update(SewadarDesignation obj);
        void Delete(int id);
        void Save();
    }

    public interface IUnitRepository
    {
        IEnumerable<Unit> SelectAll();
        Unit GetById(int id);
        void Insert(Unit obj);
        void Update(Unit obj);
        void Delete(int id);
        void Save();
    }
}
