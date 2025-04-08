using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class DashboardRepository:IDashboardRepository
    {
        private readonly AssertDBContext assertContext;
        public DashboardRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public DashboardDTO GetDashboard(int userId)
        {
            DashboardDTO dashboardDTO=new DashboardDTO();
            dashboardDTO.AssetRegister.NoOfAssertRegister = assertContext.AssertRegisters.Count(T=>T.IsActive && T.UserId==userId);
            dashboardDTO.AssetRegister.AssetStatusCount = assertContext.AssertRegisters
                                    .GroupBy(a => a.AssetStatusId)
                                    .Select(g => new StatusCountDTO
                                    {                                       
                                        Name = assertContext.AssetStatus
                                            .Where(s => s.AssetStatusId == g.Key)
                                            .Select(s => s.AssetStatusName)
                                            .FirstOrDefault(),
                                        Count = g.Count()
                                    })
                                    .ToList();

            return dashboardDTO;
        }
       
    }
}
