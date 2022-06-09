using UdemyDotnetLeaveManagement.Web.Contracts;
using UdemyDotnetLeaveManagement.Web.Data;

namespace UdemyDotnetLeaveManagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
