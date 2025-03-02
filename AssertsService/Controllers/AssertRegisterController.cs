using Microsoft.AspNetCore.Mvc;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AssertRegisterController : ControllerBase
    {
        private readonly IAssertRegisterRepository assertRegisterRepository;
        public AssertRegisterController(IAssertRegisterRepository _assertRegisterRepository)
        {
            this.assertRegisterRepository = _assertRegisterRepository;
        }

        // GET: api/<AssertRegisterController>
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAssertRegisters(int id)
        {

            try
            {
                return Ok(await assertRegisterRepository.GetAssertRegisters(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AssertRegister>> GetAssertRegister(int id)
        {

            try
            {
                var result = await assertRegisterRepository.GetAssertRegister(id);
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
        public async Task<ActionResult<AssertRegister>> AddAssertRegister(AssertRegister assertRegister)
        {

            try
            {
               
                if (assertRegister == null) return NotFound();
                var assertReg = await assertRegisterRepository.AddAssertRegister(assertRegister);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<AssertRegister>> UpdateAssertRegister(AssertRegister assertRegister)
        {
            try
            {             
                var assertReg = await assertRegisterRepository.GetAssertRegister(assertRegister.AssertRegisterId);
                if (assertReg == null) return NotFound();

                return await assertRegisterRepository.UpdateAssertRegister(assertRegister);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public  bool DeleteAssertRegister(int id)
        {
            try
            {               
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                assertRegisterRepository.DeleteAssertRegister(id);
                return true;
            }
            catch (Exception)
            {
                return false;
                 //StatusCode(StatusCodes.Status500InternalServerError, "Error deleting asserts");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetLastMaintenanceStrategy()
        {

            try
            {
                return Ok(await assertRegisterRepository.GetLastMaintenanceStrategy());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpGet]
        public async Task<ActionResult> GetAssetStatus()
        {

            try
            {
                return Ok(await assertRegisterRepository.GetAssetStatus());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpGet]
        public async Task<ActionResult> GetUtilizationRates()
        {

            try
            {
                return Ok(await assertRegisterRepository.GetUtilizationRates());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
        [HttpGet]
        public async Task<ActionResult> GetLastPriority()
        {

            try
            {
                return Ok(await assertRegisterRepository.GetLastPriority());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
    }
}
