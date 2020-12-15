using HolidayManager.Data;
using HolidayManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HolidayManager.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveTypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public bool Create(LeaveType entity)
        {
            _dbContext.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _dbContext.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            return _dbContext.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            return _dbContext.LeaveTypes.Find(id);
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _dbContext.LeaveTypes.Update(entity);
            return Save();
        }
    }
}
