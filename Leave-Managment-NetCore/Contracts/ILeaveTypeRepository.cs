using Leave_Managment_NetCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Managment_NetCore.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        LeaveType GetEmployeesByLeaveType(int ID);
    }
}
