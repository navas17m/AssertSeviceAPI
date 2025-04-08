using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IBudgetPlanRepository
    {
        Task<IEnumerable<BudgetPlanDTO>> GetBudgetPlans(int MunicipalId);
        Task<BudgetPlan> GetBudgetPlan(int budgetPlanId);
        Task<BudgetPlan> AddBudgetPlan(BudgetPlan budgetPlan);
        Task<BudgetPlan> UpdateBudgetPlan(BudgetPlan budgetPlan);
        void DeleteBudgetPlan(int budgetPlanId);

        Task<IEnumerable<MaintenanceManagementStyle>> GetMaintenanceManagementStyles();
        Task<IEnumerable<MaintenanceStrategy>> GetMaintenanceStrategies();
    }
}
