using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IWorkforceManagementRepository
    {
        Task<IEnumerable<WorkforceManagement>> GetWorkforceManagements(int MunicipalId);
        Task<WorkforceManagement> GetWorkforceManagement(int WorkforceManagementId);
        Task<WorkforceManagement> AddWorkforceManagement(WorkforceManagement WorkforceManagement);
        Task<WorkforceManagement> UpdateWorkforceManagement(WorkforceManagement WorkforceManagement);
        void DeleteWorkforceManagement(int WorkforceManagementId);
    }
}
