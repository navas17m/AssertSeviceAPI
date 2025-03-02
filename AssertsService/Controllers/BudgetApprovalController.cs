using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BudgetApprovalController : ControllerBase
    {
        private readonly IBudgetApprovalRepository BudgetApprovalRepository;
        public BudgetApprovalController(IBudgetApprovalRepository _BudgetApprovalRepository)
        {
            this.BudgetApprovalRepository = _BudgetApprovalRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetBudgetApprovals(int id)
        {

            try
            {
                return Ok(await BudgetApprovalRepository.GetBudgetApprovals(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<BudgetApproval>> GetBudgetApproval(int id)
        {

            try
            {
                var result = await BudgetApprovalRepository.GetBudgetApproval(id);
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
        public async Task<ActionResult<BudgetApproval>> AddBudgetApproval(BudgetApproval BudgetApproval)
        {
            try
            {
                if (BudgetApproval == null) return NotFound();
                var assertReg = await BudgetApprovalRepository.AddBudgetApproval(BudgetApproval);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<BudgetApproval>> UpdateBudgetApproval(BudgetApproval BudgetApproval)
        {
            try
            {
                var assertReg = await BudgetApprovalRepository.GetBudgetApproval(BudgetApproval.BudgetApprovalId);
                if (assertReg == null) return NotFound();

                return await BudgetApprovalRepository.UpdateBudgetApproval(BudgetApproval);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteBudgetApproval(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                BudgetApprovalRepository.DeleteBudgetApproval(id);
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
