using AutoMapper;
using UdemyDotnetLeaveManagement.Web.Data;
using UdemyDotnetLeaveManagement.Web.Models;

namespace UdemyDotnetLeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
