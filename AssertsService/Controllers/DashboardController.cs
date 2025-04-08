using AssertsService.DTO;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardRepository DashboardRepository;
        public DashboardController(IDashboardRepository _DashboardRepository)
        {
            this.DashboardRepository = _DashboardRepository;
        }

        [HttpGet("{id:int}")]
        public DashboardDTO GetDashboard(int id)
        {

            return DashboardRepository.GetDashboard(id);
        }
       
    }
}
