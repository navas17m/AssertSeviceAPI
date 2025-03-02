using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class WorkforceManagementRepository:IWorkforceManagementRepository
    {
        private readonly AssertDBContext assertContext;
        public WorkforceManagementRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<WorkforceManagement>> GetWorkforceManagements(int MunicipalId)
        {
            return await assertContext.WorkforceManagements.Where(T=>T.MunicipalId==MunicipalId && T.IsActive==true).ToListAsync();
        }
        public async Task<WorkforceManagement> GetWorkforceManagement(int WorkforceManagementId)
        {
            return await assertContext.WorkforceManagements.FirstOrDefaultAsync(T => T.WorkforceManagementId == WorkforceManagementId && T.IsActive == true);
        }
        public async Task<WorkforceManagement> AddWorkforceManagement(WorkforceManagement WorkforceManagement)
        {
            var result = await assertContext.WorkforceManagements.AddAsync(WorkforceManagement);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<WorkforceManagement> UpdateWorkforceManagement(WorkforceManagement WorkforceManagement)
        {
            var result = await assertContext.WorkforceManagements.FirstOrDefaultAsync(T => T.WorkforceManagementId == WorkforceManagement.WorkforceManagementId);
            if (result != null)
            {
                result.Activity = WorkforceManagement.Activity;
                result.BriefDescription = WorkforceManagement.BriefDescription;
                result.CitingReasons = WorkforceManagement.CitingReasons;
                result.Description = WorkforceManagement.Description;
                result.YesOrNo = WorkforceManagement.YesOrNo;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteWorkforceManagement(int WorkforceManagementId)
        {
            var result = assertContext.WorkforceManagements.FirstOrDefault(T => T.WorkforceManagementId == WorkforceManagementId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
    }
}
