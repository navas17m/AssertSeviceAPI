using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class ComplianceAndRegulatoryRepository:IComplianceAndRegulatoryRepository
    {
        private readonly AssertDBContext assertContext;
        public ComplianceAndRegulatoryRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<ComplianceAndRegulatory>> GetComplianceAndRegulatorys(int userId)
        {
            return await assertContext.ComplianceAndRegulatorys.Where(T=>T.UserId== userId && T.IsActive==true).ToListAsync();
        }
        public async Task<ComplianceAndRegulatory> GetComplianceAndRegulatory(int ComplianceAndRegulatoryId)
        {
            return await assertContext.ComplianceAndRegulatorys.FirstOrDefaultAsync(T => T.ComplianceAndRegulatoryId == ComplianceAndRegulatoryId && T.IsActive == true);
        }
        public async Task<ComplianceAndRegulatory> AddComplianceAndRegulatory(ComplianceAndRegulatory ComplianceAndRegulatory)
        {
            var result = await assertContext.ComplianceAndRegulatorys.AddAsync(ComplianceAndRegulatory);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<ComplianceAndRegulatory> UpdateComplianceAndRegulatory(ComplianceAndRegulatory ComplianceAndRegulatory)
        {
            var result = await assertContext.ComplianceAndRegulatorys.FirstOrDefaultAsync(T => T.ComplianceAndRegulatoryId == ComplianceAndRegulatory.ComplianceAndRegulatoryId);
            if (result != null)
            {
                result.Activity = ComplianceAndRegulatory.Activity;
                result.BriefDescription = ComplianceAndRegulatory.BriefDescription;
                result.CitingReasons = ComplianceAndRegulatory.CitingReasons;
                result.Description = ComplianceAndRegulatory.Description;
                result.YesOrNo = ComplianceAndRegulatory.YesOrNo;                             
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteComplianceAndRegulatory(int ComplianceAndRegulatoryId)
        {
            var result = assertContext.ComplianceAndRegulatorys.FirstOrDefault(T => T.ComplianceAndRegulatoryId == ComplianceAndRegulatoryId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
    }
}
