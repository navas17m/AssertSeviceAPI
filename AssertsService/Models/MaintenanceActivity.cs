using Microsoft.Extensions.Hosting;
using System.Collections;
using System.Collections.Generic;

namespace AssertsService.Models
{
    public class MaintenanceActivity
    {
        public int MaintenanceActivityId { get; set; }
        public int MunicipalId { get; set; }
        public int SubMunicipalId { get; set; }
        public int UserId { get; set; }
        public bool Maintenancemanagementstyle { get; set; }
        public string? Workordernumber { get; set; }
        public int TypeofscheduledmaintenanceId { get; set; }
        public DateTime? Dateoflastmaintenance  { get; set; }
        public DateTime? Nextmaintenancedate { get; set; }
        public int PeriodicmaintenanceId { get; set; }
        public DateTime? Workorderissuedate { get; set; }
        public DateTime? Maintenancestartdate { get; set; }
        public DateTime? Maintenancecompletiondate { get; set; }
        public int PriorityofworkId { get; set; }
        public string? Description { get; set; }
        public string? Resources { get; set; }
        public string? Estimatinglaborcosts { get; set; }
        public  bool Approvals { get; set; }
        public int WorkorderstatusId { get; set; }       
        public string? Postmaintenance  { get; set; }
        public string? Actualtimetakenformaintenance { get; set; }
        public decimal MaintenanceCost { get; set; }
        public decimal HRCost { get; set; }
        public decimal HRMaterialCost { get; set; }
        public decimal OtherCost { get; set; }
        public int PercentageCompleted { get; set; }
        public bool IsActive { get; set; }

    }
}
