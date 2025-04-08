using AssertsService.DTO;
using AssertsService.Models;

namespace AssertsService.Repository.Interface
{
    public interface IDashboardRepository
    {      
        DashboardDTO GetDashboard(int userId);       
    }
}
