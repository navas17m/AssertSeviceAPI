using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class QualityPlanandContinuousImprovementRepository:IQualityPlanandContinuousImprovementRepository
    {
        private readonly AssertDBContext assertContext;
        public QualityPlanandContinuousImprovementRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<QualityPlanandContinuousImprovement>> GetQualityPlanandContinuousImprovements(int MunicipalId)
        {
            return await assertContext.QualityPlanandContinuousImprovements.Where(T=>T.MunicipalId==MunicipalId && T.IsActive==true).ToListAsync();
        }
        public async Task<QualityPlanandContinuousImprovement> GetQualityPlanandContinuousImprovement(int QualityPlanandContinuousImprovementId)
        {
            return await assertContext.QualityPlanandContinuousImprovements.FirstOrDefaultAsync(T => T.QualityPlanandContinuousImprovementId == QualityPlanandContinuousImprovementId && T.IsActive == true);
        }
        public async Task<QualityPlanandContinuousImprovement> AddQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement QualityPlanandContinuousImprovement)
        {
            var result = await assertContext.QualityPlanandContinuousImprovements.AddAsync(QualityPlanandContinuousImprovement);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<QualityPlanandContinuousImprovement> UpdateQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement QualityPlanandContinuousImprovement)
        {
            var result = await assertContext.QualityPlanandContinuousImprovements.FirstOrDefaultAsync(T => T.QualityPlanandContinuousImprovementId == QualityPlanandContinuousImprovement.QualityPlanandContinuousImprovementId);
            if (result != null)
            {
                result.Requirement = QualityPlanandContinuousImprovement.Requirement;
                result.Description = QualityPlanandContinuousImprovement.Description;
                result.YesPartiallyNo = QualityPlanandContinuousImprovement.YesPartiallyNo;
                result.Reasons = QualityPlanandContinuousImprovement.Reasons;
                result.AttachLogFile = QualityPlanandContinuousImprovement.AttachLogFile;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteQualityPlanandContinuousImprovement(int QualityPlanandContinuousImprovementId)
        {
            var result = assertContext.QualityPlanandContinuousImprovements.FirstOrDefault(T => T.QualityPlanandContinuousImprovementId == QualityPlanandContinuousImprovementId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
    }
}
