using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MaintenanceActivityController : ControllerBase
    {
        private readonly IMaintenanceActivityRepository MaintenanceActivityRepository;
        public MaintenanceActivityController(IMaintenanceActivityRepository _MaintenanceActivityRepository)
        {
            this.MaintenanceActivityRepository = _MaintenanceActivityRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetMaintenanceActivitys(int id)
        {

            try
            {
                return Ok(await MaintenanceActivityRepository.GetMaintenanceActivitys(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<MaintenanceActivity>> GetMaintenanceActivity(int id)
        {

            try
            {
                var result = await MaintenanceActivityRepository.GetMaintenanceActivity(id);
                if (result == null) return NotFound();
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // POST api/<AssertRegisterController>        
        [HttpPost]
        public async Task<ActionResult<MaintenanceActivity>> AddMaintenanceActivity(MaintenanceActivity MaintenanceActivity)
        {
            try
            {
                if (MaintenanceActivity == null) return NotFound();
                var assertReg = await MaintenanceActivityRepository.AddMaintenanceActivity(MaintenanceActivity);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<MaintenanceActivity>> UpdateMaintenanceActivity(MaintenanceActivity MaintenanceActivity)
        {
            try
            {
                var assertReg = await MaintenanceActivityRepository.GetMaintenanceActivity(MaintenanceActivity.MaintenanceActivityId);
                if (assertReg == null) return NotFound();

                return await MaintenanceActivityRepository.UpdateMaintenanceActivity(MaintenanceActivity);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteMaintenanceActivity(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                MaintenanceActivityRepository.DeleteMaintenanceActivity(id);
                return true;
            }
            catch (Exception)
            {
                return false;
                //StatusCode(StatusCodes.Status500InternalServerError, "Error deleting asserts");
            }
        }
    }
}
