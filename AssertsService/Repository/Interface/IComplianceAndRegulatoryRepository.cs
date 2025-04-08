using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IComplianceAndRegulatoryRepository
    {
        Task<IEnumerable<ComplianceAndRegulatory>> GetComplianceAndRegulatorys(int MunicipalId);
        Task<ComplianceAndRegulatory> GetComplianceAndRegulatory(int ComplianceAndRegulatoryId);
        Task<ComplianceAndRegulatory> AddComplianceAndRegulatory(ComplianceAndRegulatory ComplianceAndRegulatory);
        Task<ComplianceAndRegulatory> UpdateComplianceAndRegulatory(ComplianceAndRegulatory ComplianceAndRegulatory);
        void DeleteComplianceAndRegulatory(int ComplianceAndRegulatoryId);
        Task<IEnumerable<ComplianceAndRegulatoryActivity>> GetComplianceAndRegulatoryActivities();
    }
}
