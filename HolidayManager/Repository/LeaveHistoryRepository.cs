using HolidayManager.Data;
using HolidayManager.Interfaces;
using System;
using System.Collections.Generic;

namespace HolidayManager.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeaveHistoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public bool Create(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveHistory FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
