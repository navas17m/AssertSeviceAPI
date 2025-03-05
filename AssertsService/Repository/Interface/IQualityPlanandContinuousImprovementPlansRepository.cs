using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IQualityPlanandContinuousImprovementRepository
    {
        Task<IEnumerable<QualityPlanandContinuousImprovement>> GetQualityPlanandContinuousImprovements(int MunicipalId);
        Task<QualityPlanandContinuousImprovement> GetQualityPlanandContinuousImprovement(int QualityPlanandContinuousImprovementId);
        Task<QualityPlanandContinuousImprovement> AddQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement QualityPlanandContinuousImprovement);
        Task<QualityPlanandContinuousImprovement> UpdateQualityPlanandContinuousImprovement(QualityPlanandContinuousImprovement QualityPlanandContinuousImprovement);
        void DeleteQualityPlanandContinuousImprovement(int QualityPlanandContinuousImprovementId);
    }
}
