using Microsoft.EntityFrameworkCore;
using AssertsService.Data;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;

namespace AssertsService.Repository.Services
{
    public class DashboardRepository:IDashboardRepository
    {
        private readonly AssertDBContext assertContext;
        public DashboardRepository(AssertDBContext _assertContext)
        {
            this.assertContext = _assertContext;
        }
        public DashboardDTO GetDashboard(int userId)
        {
            DashboardDTO dashboardDTO=new DashboardDTO();
            AssetRegisterDashboardDTO asset=new AssetRegisterDashboardDTO();
            dashboardDTO.AssertRegisterCount = assertContext.AssertRegisters.Where(T=>T.IsActive && T.UserId==userId).Count();
            dashboardDTO.BudgetPlanCount = assertContext.BudgetPlans.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.BudgetApprovalCount = assertContext.BudgetApprovals.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.KPICount = assertContext.KeyPerformanceIndicators.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.RiskManagementCount = assertContext.RiskManagementandContingencyPlans.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.QualityPlanCount = assertContext.QualityPlanandContinuousImprovements.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.ComplianceandregulatoryCount = assertContext.ComplianceAndRegulatorys.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.WorkforceManagementCount = assertContext.WorkforceManagements.Where(T => T.IsActive && T.UserId == userId).Count();
            dashboardDTO.WorkOrderCount = assertContext.MaintenanceActivitys.Where(T => T.IsActive && T.UserId == userId).Count();
            decimal hrCost= assertContext.MaintenanceActivitys.Where(T => T.IsActive && T.UserId == userId).Sum(T => T.HRCost);
            decimal hrMaterialCost = assertContext.MaintenanceActivitys.Where(T => T.IsActive && T.UserId == userId).Sum(T => T.HRMaterialCost);
            decimal hrOtherCost = assertContext.MaintenanceActivitys.Where(T => T.IsActive && T.UserId == userId).Sum(T => T.OtherCost);
            dashboardDTO.HRCost = hrCost;
            dashboardDTO.HRMaterialCost = hrMaterialCost;
            dashboardDTO.OtherCost = hrOtherCost;
            dashboardDTO.TotalCost = hrCost + hrMaterialCost + hrOtherCost;
            dashboardDTO.WorkOrderOpenCount = assertContext.MaintenanceActivitys.Where(T => T.WorkorderstatusId==1 && T.IsActive && T.UserId == userId).Count();
            dashboardDTO.WorkOrderInProgressCount = assertContext.MaintenanceActivitys.Where(T => T.WorkorderstatusId == 2 && T.IsActive && T.UserId == userId).Count();
            dashboardDTO.WorkOrderPendingCount = assertContext.MaintenanceActivitys.Where(T => T.WorkorderstatusId == 3 && T.IsActive && T.UserId == userId).Count();
            dashboardDTO.WorkOrderClosedCount = assertContext.MaintenanceActivitys.Where(T => T.WorkorderstatusId == 4 && T.IsActive && T.UserId == userId).Count();
           
            dashboardDTO.TypeOfMaintance = assertContext.MaintenanceActivitys.Where(T=>T.TypeofscheduledmaintenanceId!=0 && T.IsActive && T.UserId == userId)
                                    .GroupBy(a => a.TypeofscheduledmaintenanceId)
                                    .Select(g => new StatusCountDTO
                                    {
                                        Name = assertContext.TypeofScheduledMaintenances
                                            .Where(s => s.TypeofScheduledMaintenanceId == g.Key)
                                            .Select(s => s.TypeofScheduledMaintenanceName)
                                            .FirstOrDefault(),
                                        Count = g.Count()
                                    }).ToList();
            
            return dashboardDTO;
        }
       
    }
}
