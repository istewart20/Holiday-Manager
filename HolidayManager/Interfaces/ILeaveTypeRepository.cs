using HolidayManager.Data;
using System.Collections.Generic;

namespace HolidayManager.Interfaces
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
