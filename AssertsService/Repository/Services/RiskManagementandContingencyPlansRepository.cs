using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class RiskManagementandContingencyPlanRepository:IRiskManagementandContingencyPlansRepository
    {
        private readonly AssertDBContext assertContext;
        public RiskManagementandContingencyPlanRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<RiskManagementandContingencyPlan>> GetRiskManagementandContingencyPlans(int MunicipalId)
        {
            return await assertContext.RiskManagementandContingencyPlans.Where(T=>T.MunicipalId==MunicipalId && T.IsActive==true).ToListAsync();
        }
        public async Task<RiskManagementandContingencyPlan> GetRiskManagementandContingencyPlan(int RiskManagementandContingencyPlanId)
        {
            return await assertContext.RiskManagementandContingencyPlans.FirstOrDefaultAsync(T => T.RiskManagementandContingencyPlanId == RiskManagementandContingencyPlanId && T.IsActive == true);
        }
        public async Task<RiskManagementandContingencyPlan> AddRiskManagementandContingencyPlan(RiskManagementandContingencyPlan RiskManagementandContingencyPlan)
        {
            var result = await assertContext.RiskManagementandContingencyPlans.AddAsync(RiskManagementandContingencyPlan);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<RiskManagementandContingencyPlan> UpdateRiskManagementandContingencyPlan(RiskManagementandContingencyPlan RiskManagementandContingencyPlan)
        {
            var result = await assertContext.RiskManagementandContingencyPlans.FirstOrDefaultAsync(T => T.RiskManagementandContingencyPlanId == RiskManagementandContingencyPlan.RiskManagementandContingencyPlanId);
            if (result != null)
            {
                result.Requirement = RiskManagementandContingencyPlan.Requirement;
                result.Description = RiskManagementandContingencyPlan.Description;
                result.YesPartiallyNo = RiskManagementandContingencyPlan.YesPartiallyNo;
                result.Reasons = RiskManagementandContingencyPlan.Reasons;
                result.UploadId = RiskManagementandContingencyPlan.UploadId;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteRiskManagementandContingencyPlan(int RiskManagementandContingencyPlanId)
        {
            var result = assertContext.RiskManagementandContingencyPlans.FirstOrDefault(T => T.RiskManagementandContingencyPlanId == RiskManagementandContingencyPlanId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
    }
}
