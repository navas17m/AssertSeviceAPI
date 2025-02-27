using AssertsService.Models;
using AssertsService.DTO;
namespace AssertsService.Repository.Interface
{
    public interface IAssertRegisterRepository
    {
        Task<IEnumerable<AssertRegisterDTO>> GetAssertRegisters();
        Task<AssertRegister> GetAssertRegister(int assertRegisterId);
        Task<AssertRegister> AddAssertRegister(AssertRegister assertRegister);
        Task<AssertRegister> UpdateAssertRegister(AssertRegister assertRegister);
        void DeleteAssertRegister(int AssertRegisterId);
        Task<IEnumerable<LastMaintenanceStrategy>> GetLastMaintenanceStrategy();
        Task<IEnumerable<AssetStatus>> GetAssetStatus();
        Task<IEnumerable<UtilizationRates>> GetUtilizationRates();
        Task<IEnumerable<Priority>> GetLastPriority();
    }
}
