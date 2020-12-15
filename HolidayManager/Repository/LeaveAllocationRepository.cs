using HolidayManager.Data;
using HolidayManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            _dbContext.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            return _dbContext.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _dbContext.LeaveAllocations.Find(id);
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _dbContext.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
