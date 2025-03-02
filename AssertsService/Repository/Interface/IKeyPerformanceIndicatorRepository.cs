using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IKeyPerformanceIndicatorRepository
    {
        Task<IEnumerable<KeyPerformanceIndicatorDTO>> GetKeyPerformanceIndicators(int MunicipalId);
        Task<KeyPerformanceIndicator> GetKeyPerformanceIndicator(int KeyPerformanceIndicatorId);
        Task<KeyPerformanceIndicator> AddKeyPerformanceIndicator(KeyPerformanceIndicator KeyPerformanceIndicator);
        Task<KeyPerformanceIndicator> UpdateKeyPerformanceIndicator(KeyPerformanceIndicator KeyPerformanceIndicator);
        void DeleteKeyPerformanceIndicator(int KeyPerformanceIndicatorId);
        Task<IEnumerable<KeyPerformanceIndicatorCategory>> GetKeyPerformanceIndicatorCategorys();
    }
}
