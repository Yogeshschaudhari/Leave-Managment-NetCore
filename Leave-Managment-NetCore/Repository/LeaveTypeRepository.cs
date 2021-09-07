using Leave_Managment_NetCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leave_Managment_NetCore.Contracts;

namespace Leave_Managment_NetCore.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Save(LeaveType entity)
        {
            int changes = _db.SaveChanges();
            return changes > 0;
        }

        bool IRepositoryBase<LeaveType>.Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save(entity);
        }

        bool IRepositoryBase<LeaveType>.Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save(entity);
        }

        ICollection<LeaveType> IRepositoryBase<LeaveType>.FindAll()
        {
            return _db.LeaveTypes.ToList();
        }

        LeaveType IRepositoryBase<LeaveType>.FindByID(int id)
        {
            return _db.LeaveTypes.Find(id);
        }

        LeaveType ILeaveTypeRepository.GetEmployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        bool IRepositoryBase<LeaveType>.Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save(entity);
        }
    }
}
