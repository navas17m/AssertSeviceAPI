using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IRiskManagementandContingencyPlansRepository
    {
        Task<IEnumerable<RiskManagementandContingencyPlan>> GetRiskManagementandContingencyPlans(int MunicipalId);
        Task<RiskManagementandContingencyPlan> GetRiskManagementandContingencyPlan(int RiskManagementandContingencyPlanId);
        Task<RiskManagementandContingencyPlan> AddRiskManagementandContingencyPlan(RiskManagementandContingencyPlan RiskManagementandContingencyPlan);
        Task<RiskManagementandContingencyPlan> UpdateRiskManagementandContingencyPlan(RiskManagementandContingencyPlan RiskManagementandContingencyPlan);
        void DeleteRiskManagementandContingencyPlan(int RiskManagementandContingencyPlanId);
    }
}
