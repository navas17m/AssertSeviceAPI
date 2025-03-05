using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IMaintenanceActivityRepository
    {
        Task<IEnumerable<MaintenanceActivity>> GetMaintenanceActivitys(int MunicipalId);
        Task<MaintenanceActivity> GetMaintenanceActivity(int MaintenanceActivityId);
        Task<MaintenanceActivity> AddMaintenanceActivity(MaintenanceActivity MaintenanceActivity);
        Task<MaintenanceActivity> UpdateMaintenanceActivity(MaintenanceActivity MaintenanceActivity);
        void DeleteMaintenanceActivity(int MaintenanceActivityId);
    }
}
