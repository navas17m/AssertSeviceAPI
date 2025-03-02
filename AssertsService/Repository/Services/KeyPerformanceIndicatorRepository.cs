using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class KeyPerformanceIndicatorRepository : IKeyPerformanceIndicator
    {
        private readonly AssertDBContext assertContext;
        public KeyPerformanceIndicatorRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<KeyPerformanceIndicator>> GetKeyPerformanceIndicators(int MunicipalId)
        {
            return await assertContext.KeyPerformanceIndicators.Where(T=>T.MunicipalId==MunicipalId && T.IsActive==true).ToListAsync();
        }
        public async Task<KeyPerformanceIndicator> GetKeyPerformanceIndicator(int KeyPerformanceIndicatorId)
        {
            return await assertContext.KeyPerformanceIndicators.FirstOrDefaultAsync(T => T.KeyPerformanceIndicatorId == KeyPerformanceIndicatorId && T.IsActive == true);
        }
        public async Task<KeyPerformanceIndicator> AddKeyPerformanceIndicator(KeyPerformanceIndicator keyPerformanceIndicator)
        {
            var result = await assertContext.KeyPerformanceIndicators.AddAsync(keyPerformanceIndicator);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<KeyPerformanceIndicator> UpdateKeyPerformanceIndicator(KeyPerformanceIndicator keyPerformanceIndicator)
        {
            var result = await assertContext.KeyPerformanceIndicators.FirstOrDefaultAsync(T => T.KeyPerformanceIndicatorId == keyPerformanceIndicator.KeyPerformanceIndicatorId);
            if (result != null)
            {
                result.KeyPerformanceIndicatorCategorylId = keyPerformanceIndicator.KeyPerformanceIndicatorCategorylId;
                result.KeyPerformanceIndicatorName = keyPerformanceIndicator.KeyPerformanceIndicatorName;
                result.Description = keyPerformanceIndicator.Description;
                result.Baseline = keyPerformanceIndicator.Baseline;
                result.ComingThrough = keyPerformanceIndicator.ComingThrough;                         
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteKeyPerformanceIndicator(int KeyPerformanceIndicatorId)
        {
            var result = assertContext.KeyPerformanceIndicators.FirstOrDefault(T => T.KeyPerformanceIndicatorId == KeyPerformanceIndicatorId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
        public async Task<IEnumerable<KeyPerformanceIndicatorCategory>> GetKeyPerformanceIndicatorCategorys()
        {
            return await assertContext.KeyPerformanceIndicatorCategorys.ToListAsync();
        }
    }
}
