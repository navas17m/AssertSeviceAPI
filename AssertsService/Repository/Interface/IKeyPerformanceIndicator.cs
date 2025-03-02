using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IKeyPerformanceIndicator
    {
        Task<IEnumerable<KeyPerformanceIndicator>> GetKeyPerformanceIndicators(int MunicipalId);
        Task<KeyPerformanceIndicator> GetKeyPerformanceIndicator(int KeyPerformanceIndicatorId);
        Task<KeyPerformanceIndicator> AddKeyPerformanceIndicator(KeyPerformanceIndicator KeyPerformanceIndicator);
        Task<KeyPerformanceIndicator> UpdateKeyPerformanceIndicator(KeyPerformanceIndicator KeyPerformanceIndicator);
        void DeleteKeyPerformanceIndicator(int KeyPerformanceIndicatorId);
    }
}
