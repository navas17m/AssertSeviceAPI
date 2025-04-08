using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class BudgetApprovalRepository:IBudgetApprovalRepository
    {
        private readonly AssertDBContext assertContext;
        public BudgetApprovalRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<BudgetApproval>> GetBudgetApprovals(int userId)
        {
            return await assertContext.BudgetApprovals.Where(T=>T.UserId== userId && T.IsActive==true).ToListAsync();
        }
        public async Task<BudgetApproval> GetBudgetApproval(int BudgetApprovalId)
        {
            return await assertContext.BudgetApprovals.FirstOrDefaultAsync(T => T.BudgetApprovalId == BudgetApprovalId && T.IsActive == true);
        }
        public async Task<BudgetApproval> AddBudgetApproval(BudgetApproval BudgetApproval)
        {
            var result = await assertContext.BudgetApprovals.AddAsync(BudgetApproval);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<BudgetApproval> UpdateBudgetApproval(BudgetApproval BudgetApproval)
        {
            var result = await assertContext.BudgetApprovals.FirstOrDefaultAsync(T => T.BudgetApprovalId == BudgetApproval.BudgetApprovalId);
            if (result != null)
            {
                result.BudgetApprovals = BudgetApproval.BudgetApprovals;
                result.BudgetApprovalReason = BudgetApproval.BudgetApprovalReason;
                result.MonitoringBudgetImplementation = BudgetApproval.MonitoringBudgetImplementation;
                result.PeriodicReports = BudgetApproval.PeriodicReports;
                result.EmergencyModifications = BudgetApproval.EmergencyModifications;
                result.EmergencyModificationReason = BudgetApproval.EmergencyModificationReason;
                result.BudgetDisparity = BudgetApproval.BudgetDisparity;
                result.BudgetDisparityAction = BudgetApproval.BudgetDisparityAction;
                result.BudgetDisparityDescription = BudgetApproval.BudgetDisparityDescription;
                result.UploadId = BudgetApproval.UploadId;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteBudgetApproval(int BudgetApprovalId)
        {
            var result = assertContext.BudgetApprovals.FirstOrDefault(T => T.BudgetApprovalId == BudgetApprovalId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
    }
}
