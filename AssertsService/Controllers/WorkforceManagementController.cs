using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WorkforceManagementController : ControllerBase
    {
        private readonly IWorkforceManagementRepository WorkforceManagementRepository;
        public WorkforceManagementController(IWorkforceManagementRepository _WorkforceManagementRepository)
        {
            this.WorkforceManagementRepository = _WorkforceManagementRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetWorkforceManagements(int id)
        {

            try
            {
                return Ok(await WorkforceManagementRepository.GetWorkforceManagements(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<WorkforceManagement>> GetWorkforceManagement(int id)
        {

            try
            {
                var result = await WorkforceManagementRepository.GetWorkforceManagement(id);
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
        public async Task<ActionResult<WorkforceManagement>> AddWorkforceManagement(WorkforceManagement WorkforceManagement)
        {
            try
            {
                if (WorkforceManagement == null) return NotFound();
                var assertReg = await WorkforceManagementRepository.AddWorkforceManagement(WorkforceManagement);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<WorkforceManagement>> UpdateWorkforceManagement(WorkforceManagement WorkforceManagement)
        {
            try
            {
                var assertReg = await WorkforceManagementRepository.GetWorkforceManagement(WorkforceManagement.WorkforceManagementId);
                if (assertReg == null) return NotFound();

                return await WorkforceManagementRepository.UpdateWorkforceManagement(WorkforceManagement);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteWorkforceManagement(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                WorkforceManagementRepository.DeleteWorkforceManagement(id);
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
