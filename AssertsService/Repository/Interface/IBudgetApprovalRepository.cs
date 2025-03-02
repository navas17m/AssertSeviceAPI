using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IBudgetApprovalRepository
    {
        Task<IEnumerable<BudgetApproval>> GetBudgetApprovals(int MunicipalId);
        Task<BudgetApproval> GetBudgetApproval(int budgetApprovalId);
        Task<BudgetApproval> AddBudgetApproval(BudgetApproval budgetApproval);
        Task<BudgetApproval> UpdateBudgetApproval(BudgetApproval budgetApproval);
        void DeleteBudgetApproval(int budgetApprovalId);
    }
}
