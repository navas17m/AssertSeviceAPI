using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class KeyPerformanceIndicatorRepository : IKeyPerformanceIndicatorRepository
    {
        private readonly AssertDBContext assertContext;
        public KeyPerformanceIndicatorRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<KeyPerformanceIndicatorDTO>> GetKeyPerformanceIndicators(int userId)
        {
            return await (from KP in assertContext.KeyPerformanceIndicators join KPC in assertContext.KeyPerformanceIndicatorCategorys
                          on KP.KeyPerformanceIndicatorCategoryId equals KPC.KeyPerformanceIndicatorCategoryId
                          join KPI in assertContext.KeyPerformanceIndicatorNames on KP.KeyPerformanceIndicatorNameId equals KPI.KeyPerformanceIndicatorNameId
                          where KP.UserId== userId && KP.IsActive
                          select new KeyPerformanceIndicatorDTO { 
                            KeyPerformanceIndicatorId=KP.KeyPerformanceIndicatorId,
                            KeyPerformanceIndicatorCategorylName=KPC.KeyPerformanceIndicatorCategoryName,
                            KeyPerformanceIndicatorName = KPI.KeyPerformanceIndicator,
                            Description=KP.Description
                           
                          }).ToListAsync();
            //assertContext.KeyPerformanceIndicators.Where(T=>T.MunicipalId==MunicipalId && T.IsActive==true).ToListAsync();
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
                result.KeyPerformanceIndicatorCategoryId = keyPerformanceIndicator.KeyPerformanceIndicatorCategoryId;
                result.KeyPerformanceIndicatorNameId = keyPerformanceIndicator.KeyPerformanceIndicatorNameId;
                result.Description = keyPerformanceIndicator.Description;                                    
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
        public async Task<IEnumerable<KeyPerformanceIndicatorName>> GetKeyPerformanceIndicatorNames(int Id)
        {
            return await assertContext.KeyPerformanceIndicatorNames.Where(T=>T.KeyPerformanceIndicatorCategoryId == Id).ToListAsync();
        }
    }
}
