using Microsoft.AspNetCore.Mvc;
using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.DTO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KeyPerformanceIndicatorController : ControllerBase
    {
        private readonly IKeyPerformanceIndicatorRepository KeyPerformanceIndicatorRepository;
        public KeyPerformanceIndicatorController(IKeyPerformanceIndicatorRepository _KeyPerformanceIndicatorRepository)
        {
            this.KeyPerformanceIndicatorRepository = _KeyPerformanceIndicatorRepository;
        }

        // GET: api/<KeyPerformanceIndicatorController>
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetKeyPerformanceIndicators(int id)
        {

            try
            {
                return Ok(await KeyPerformanceIndicatorRepository.GetKeyPerformanceIndicators(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<KeyPerformanceIndicatorController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<KeyPerformanceIndicator>> GetKeyPerformanceIndicator(int id)
        {

            try
            {
                var result = await KeyPerformanceIndicatorRepository.GetKeyPerformanceIndicator(id);
                if (result == null) return NotFound();
                return result;                
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // POST api/<KeyPerformanceIndicatorController>        
        [HttpPost]
        public async Task<ActionResult<KeyPerformanceIndicator>> AddKeyPerformanceIndicator(KeyPerformanceIndicator KeyPerformanceIndicator)
        {

            try
            {
               
                if (KeyPerformanceIndicator == null) return NotFound();
                var assertReg = await KeyPerformanceIndicatorRepository.AddKeyPerformanceIndicator(KeyPerformanceIndicator);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<KeyPerformanceIndicatorController>/5
        [HttpPut]
        public async Task<ActionResult<KeyPerformanceIndicator>> UpdateKeyPerformanceIndicator(KeyPerformanceIndicator KeyPerformanceIndicator)
        {
            try
            {             
                var assertReg = await KeyPerformanceIndicatorRepository.GetKeyPerformanceIndicator(KeyPerformanceIndicator.KeyPerformanceIndicatorId);
                if (assertReg == null) return NotFound();

                return await KeyPerformanceIndicatorRepository.UpdateKeyPerformanceIndicator(KeyPerformanceIndicator);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<KeyPerformanceIndicatorController>/5
        [HttpDelete("{id:int}")]
        public  bool DeleteKeyPerformanceIndicator(int id)
        {
            try
            {               
                //var assertReg =  KeyPerformanceIndicatorRepository.GetKeyPerformanceIndicator(id);
                //if (assertReg == null)  NotFound();

                KeyPerformanceIndicatorRepository.DeleteKeyPerformanceIndicator(id);
                return true;
            }
            catch (Exception)
            {
                return false;
                 //StatusCode(StatusCodes.Status500InternalServerError, "Error deleting asserts");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetKeyPerformanceIndicatorCategorys()
        {

            try
            {
                return Ok(await KeyPerformanceIndicatorRepository.GetKeyPerformanceIndicatorCategorys());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }
       
    }
}
