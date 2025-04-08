using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BudgetPlanController : ControllerBase
    {
        private readonly IBudgetPlanRepository budgetPlanRepository;
        public BudgetPlanController(IBudgetPlanRepository _budgetPlanRepository)
        {
            this.budgetPlanRepository = _budgetPlanRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetBudgetPlans(int id)
        {

            try
            {
                return Ok(await budgetPlanRepository.GetBudgetPlans(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<BudgetPlan>> GetBudgetPlan(int id)
        {

            try
            {
                var result = await budgetPlanRepository.GetBudgetPlan(id);
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
        public async Task<ActionResult<BudgetPlan>> AddBudgetPlan(BudgetPlan budgetPlan)
        {
            try
            {
                if (budgetPlan == null) return NotFound();
                var assertReg = await budgetPlanRepository.AddBudgetPlan(budgetPlan);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<BudgetPlan>> UpdateBudgetPlan(BudgetPlan budgetPlan)
        {
            try
            {
                var assertReg = await budgetPlanRepository.GetBudgetPlan(budgetPlan.BudgetPlanId);
                if (assertReg == null) return NotFound();

                return await budgetPlanRepository.UpdateBudgetPlan(budgetPlan);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteBudgetPlan(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                budgetPlanRepository.DeleteBudgetPlan(id);
                return true;
            }
            catch (Exception)
            {
                return false;
                //StatusCode(StatusCodes.Status500InternalServerError, "Error deleting asserts");
            }
        }
        public async Task<ActionResult> GetMaintenanceManagementStyles()
        {

            try
            {
                return Ok(await budgetPlanRepository.GetMaintenanceManagementStyles());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        public async Task<ActionResult> GetMaintenanceStrategies()
        {

            try
            {
                return Ok(await budgetPlanRepository.GetMaintenanceStrategies());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
    }
}
