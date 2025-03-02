using AssertsService.Models;
using AssertsService.Repository.Interface;
using AssertsService.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssertsService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ComplianceAndRegulatoryController : ControllerBase
    {
        private readonly IComplianceAndRegulatoryRepository ComplianceAndRegulatoryRepository;
        public ComplianceAndRegulatoryController(IComplianceAndRegulatoryRepository _ComplianceAndRegulatoryRepository)
        {
            this.ComplianceAndRegulatoryRepository = _ComplianceAndRegulatoryRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetComplianceAndRegulatorys(int id)
        {

            try
            {
                return Ok(await ComplianceAndRegulatoryRepository.GetComplianceAndRegulatorys(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        // GET api/<AssertRegisterController>/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ComplianceAndRegulatory>> GetComplianceAndRegulatory(int id)
        {

            try
            {
                var result = await ComplianceAndRegulatoryRepository.GetComplianceAndRegulatory(id);
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
        public async Task<ActionResult<ComplianceAndRegulatory>> AddComplianceAndRegulatory(ComplianceAndRegulatory ComplianceAndRegulatory)
        {
            try
            {
                if (ComplianceAndRegulatory == null) return NotFound();
                var assertReg = await ComplianceAndRegulatoryRepository.AddComplianceAndRegulatory(ComplianceAndRegulatory);
                return assertReg;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error Creating Asserts");
            }
        }

        // PUT api/<AssertRegisterController>/5
        [HttpPut]
        public async Task<ActionResult<ComplianceAndRegulatory>> UpdateComplianceAndRegulatory(ComplianceAndRegulatory ComplianceAndRegulatory)
        {
            try
            {
                var assertReg = await ComplianceAndRegulatoryRepository.GetComplianceAndRegulatory(ComplianceAndRegulatory.ComplianceAndRegulatoryId);
                if (assertReg == null) return NotFound();

                return await ComplianceAndRegulatoryRepository.UpdateComplianceAndRegulatory(ComplianceAndRegulatory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating asserts");
            }
        }

        // DELETE api/<AssertRegisterController>/5
        [HttpDelete("{id:int}")]
        public bool DeleteComplianceAndRegulatory(int id)
        {
            try
            {
                //var assertReg =  assertRegisterRepository.GetAssertRegister(id);
                //if (assertReg == null)  NotFound();

                ComplianceAndRegulatoryRepository.DeleteComplianceAndRegulatory(id);
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
