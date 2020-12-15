using HolidayManager.Data;
using HolidayManager.Interfaces;
using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public bool Delete(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveType FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveType entity)
        {
            throw new NotImplementedException();
        }
    }
}
