using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class MaintenanceActivityRepository:IMaintenanceActivityRepository
    {
        private readonly AssertDBContext assertContext;
        public MaintenanceActivityRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public async Task<IEnumerable<MaintenanceActivity>> GetMaintenanceActivitys(int userId)
        {
            return await assertContext.MaintenanceActivitys.Where(T=>T.UserId== userId && T.IsActive==true).ToListAsync();
        }
        public async Task<MaintenanceActivity> GetMaintenanceActivity(int MaintenanceActivityId)
        {
            return await assertContext.MaintenanceActivitys.FirstOrDefaultAsync(T => T.MaintenanceActivityId == MaintenanceActivityId && T.IsActive == true);
        }
        public async Task<MaintenanceActivity> AddMaintenanceActivity(MaintenanceActivity MaintenanceActivity)
        {
            var result = await assertContext.MaintenanceActivitys.AddAsync(MaintenanceActivity);
            await assertContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<MaintenanceActivity> UpdateMaintenanceActivity(MaintenanceActivity MaintenanceActivity)
        {
            var result = await assertContext.MaintenanceActivitys.FirstOrDefaultAsync(T => T.MaintenanceActivityId == MaintenanceActivity.MaintenanceActivityId);
            if (result != null)
            {
                result.Maintenancemanagementstyle = MaintenanceActivity.Maintenancemanagementstyle;
                result.Workordernumber = MaintenanceActivity.Workordernumber;
                result.TypeofscheduledmaintenanceId = MaintenanceActivity.TypeofscheduledmaintenanceId;
                result.Dateoflastmaintenance = MaintenanceActivity.Dateoflastmaintenance;
                result.Nextmaintenancedate = MaintenanceActivity.Nextmaintenancedate;
                result.PeriodicmaintenanceId = MaintenanceActivity.PeriodicmaintenanceId;
                result.Workorderissuedate = MaintenanceActivity.Workorderissuedate;
                result.Maintenancestartdate = MaintenanceActivity.Maintenancestartdate;
                result.Maintenancecompletiondate = MaintenanceActivity.Maintenancecompletiondate;
                result.PriorityofworkId = MaintenanceActivity.PriorityofworkId;
                result.Description = MaintenanceActivity.Description;
                result.Resources = MaintenanceActivity.Resources;
                result.Estimatinglaborcosts = MaintenanceActivity.Estimatinglaborcosts;
                result.Approvals = MaintenanceActivity.Approvals;
                result.WorkorderstatusId = MaintenanceActivity.WorkorderstatusId;
                result.Postmaintenance = MaintenanceActivity.Postmaintenance;
                result.Actualtimetakenformaintenance = MaintenanceActivity.Actualtimetakenformaintenance;
                result.MaintenanceCost = MaintenanceActivity.MaintenanceCost;
                result.HRCost = MaintenanceActivity.HRCost;
                result.HRMaterialCost = MaintenanceActivity.HRMaterialCost;
                result.OtherCost = MaintenanceActivity.OtherCost;
                result.PercentageCompleted=MaintenanceActivity.PercentageCompleted;
                await assertContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public void DeleteMaintenanceActivity(int MaintenanceActivityId)
        {
            var result = assertContext.MaintenanceActivitys.FirstOrDefault(T => T.MaintenanceActivityId == MaintenanceActivityId);
            if (result != null)
            {
                result.IsActive = false;                
                assertContext.SaveChanges();
            }
        }
        public async Task<IEnumerable<PriorityOfWork>> GetPriorityOfWorks()
        {
            return await assertContext.PriorityOfWorks.ToListAsync();
        }
        public async Task<IEnumerable<PeriodicMaintenance>> GetPeriodicMaintenances()
        {
            return await assertContext.PeriodicMaintenances.ToListAsync();
        }
        public async Task<IEnumerable<WorkOrderStatus>> GetWorkOrderStatuses()
        {
            return await assertContext.WorkOrderStatuses.ToListAsync();
        }
        public async Task<IEnumerable<TypeofScheduledMaintenance>> GetTypeofScheduledMaintenances()
        {
            return await assertContext.TypeofScheduledMaintenances.ToListAsync();
        }
    }
}
