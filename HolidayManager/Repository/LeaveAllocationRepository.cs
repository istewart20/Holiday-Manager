using HolidayManager.Data;
using HolidayManager.Interfaces;
using System;
using System.Collections.Generic;

namespace HolidayManager.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveAllocationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public bool Create(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
