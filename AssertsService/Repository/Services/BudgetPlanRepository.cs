using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class BudgetPlanRepository:IBudgetPlanRepository
    {
        private readonly AssertDBContext assertContext;
        public BudgetPlanRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<BudgetPlanDTO>> GetBudgetPlans(int userId)
        {
            return await (from AS in assertContext.BudgetPlans
                          where AS.UserId == userId && AS.IsActive == true
                          select new BudgetPlanDTO
                          {
                              BudgetPlanId = AS.BudgetPlanId,
                              EquipmentCosts = AS.EquipmentCosts,
                              HRCosts = AS.HRCosts,
                              MaterialCosts=AS.MaterialCosts,
                              MaintenanceManagementStyle = (from M in assertContext.MaintenanceManagementStyles 
                                                            where M.MaintenanceManagementStyleId == AS.MaintenanceManagementStyleId 
                                                            select M.MaintenanceManagementStyleName).FirstOrDefault(),
                              MaintenanceStrategy = (from M in assertContext.MaintenanceStrategies
                                                            where M.MaintenanceStrategyId == AS.MaintenanceStrategyId
                                                     select M.MaintenanceStrategyName).FirstOrDefault(),


                          }).ToListAsync();//assertContext.BudgetPlans.Where(T=>T.UserId== userId && T.IsActive==true).ToListAsync();
        }
        public async Task<BudgetPlan> GetBudgetPlan(int budgetPlanId)
        {
            return await assertContext.BudgetPlans.FirstOrDefaultAsync(T => T.BudgetPlanId == budgetPlanId && T.IsActive == true);
        }
        public async Task<BudgetPlan> AddBudgetPlan(BudgetPlan budgetPlan)
        {
            var result = await assertContext.BudgetPlans.AddAsync(budgetPlan);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<BudgetPlan> UpdateBudgetPlan(BudgetPlan budgetPlan)
        {
            var result = await assertContext.BudgetPlans.FirstOrDefaultAsync(T => T.BudgetPlanId == budgetPlan.BudgetPlanId);
            if (result != null)
            {
                result.MaintenanceManagementStyleId = budgetPlan.MaintenanceManagementStyleId;
                result.MaintenanceStrategyId = budgetPlan.MaintenanceStrategyId;
                result.HRCosts = budgetPlan.HRCosts;
                result.MaterialCosts = budgetPlan.MaterialCosts;
                result.EquipmentCosts = budgetPlan.EquipmentCosts;
                result.AdministrativeCosts = budgetPlan.AdministrativeCosts;
                result.OperationalCosts = budgetPlan.OperationalCosts;
                result.AllocationEmergencyEudget = budgetPlan.AllocationEmergencyEudget;
                result.EstimationOfMaintenance = budgetPlan.EstimationOfMaintenance;
                result.ReviewGistoricalData = budgetPlan.ReviewGistoricalData;
                result.UploadId = budgetPlan.UploadId;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteBudgetPlan(int budgetPlanId)
        {
            var result = assertContext.BudgetPlans.FirstOrDefault(T => T.BudgetPlanId == budgetPlanId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
        public async Task<IEnumerable<MaintenanceManagementStyle>> GetMaintenanceManagementStyles()
        {
            return await assertContext.MaintenanceManagementStyles.ToListAsync();
        }
        public async Task<IEnumerable<MaintenanceStrategy>> GetMaintenanceStrategies()
        {
            return await assertContext.MaintenanceStrategies.ToListAsync();
        }
    }
}
