using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RiskManagementandContingencyPlanController : ControllerBase
    {
        private readonly IRiskManagementandContingencyPlansRepository RiskManagementandContingencyPlanRepository;
        public RiskManagementandContingencyPlanController(IRiskManagementandContingencyPlansRepository _RiskManagementandContingencyPlanRepository)
        {
            this.RiskManagementandContingencyPlanRepository = _RiskManagementandContingencyPlanRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetRiskManagementandContingencyPlans(int id)
        {

            try
            {
                return Ok(await RiskManagementandContingencyPlanRepository.GetRiskManagementandContingencyPlans(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<RiskManagementandContingencyPlan>> GetRiskManagementandContingencyPlan(int id)
        {

            try
            {
                var result = await RiskManagementandContingencyPlanRepository.GetRiskManagementandContingencyPlan(id);
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
        public async Task<ActionResult<RiskManagementandContingencyPlan>> AddRiskManagementandContingencyPlan(RiskManagementandContingencyPlan RiskManagementandContingencyPlan)
        {
            try
            {               
                if (RiskManagementandContingencyPlan == null) return NotFound();
                var assertReg = await RiskManagementandContingencyPlanRepository.AddRiskManagementandContingencyPlan(RiskManagementandContingencyPlan);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<RiskManagementandContingencyPlan>> UpdateRiskManagementandContingencyPlan(RiskManagementandContingencyPlan RiskManagementandContingencyPlan)
        {
            try
            {
                var assertReg = await RiskManagementandContingencyPlanRepository.GetRiskManagementandContingencyPlan(RiskManagementandContingencyPlan.RiskManagementandContingencyPlanId);
                if (assertReg == null) return NotFound();

                return await RiskManagementandContingencyPlanRepository.UpdateRiskManagementandContingencyPlan(RiskManagementandContingencyPlan);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteRiskManagementandContingencyPlan(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                RiskManagementandContingencyPlanRepository.DeleteRiskManagementandContingencyPlan(id);
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
